using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nsfxr.UI
{
    public partial class ValueSlider : UserControl
    {
        public delegate void ValueUpdatedEvent(object sender, EventArgs args);
        public event ValueUpdatedEvent ValueUpdated;

        private const float TOLERANCE = 0.005f;

        public ValueSlider()
        {
            _isUpdating = true;
            InitializeComponent();
            MinValue = 0;
            MaxValue = 1;
            Precision = 4;
            Value = 0.5f;
            _isUpdating = false;
            UpdateUI();
        }

        private float _value;
        private float _minValue;
        private float _maxValue;
        private bool _isUpdating;

        public int Precision { get; set; }

        public float Value
        {
            get
            {
                if(Math.Abs(MaxValue - _value) < TOLERANCE) return MaxValue;
                if(Math.Abs(_value - MinValue) < TOLERANCE) return MinValue;
                return (float) Math.Round(_value, Precision, MidpointRounding.ToEven);
            }

            set
            {
                if (value > MaxValue)
                    _value = MaxValue;
                else if (value < MinValue)
                    _value = MinValue;
                else
                    _value = value;

                UpdateUI();        
            }
        }

        public float MinValue
        {
            get
            {
                return _minValue;
            }

            set
            {
                _minValue = (value > MaxValue) ? MaxValue : value;                
                UpdateUI();
            }
        }

        public float MaxValue
        {
            get
            {
                return _maxValue;
            }

            set
            {
                _maxValue = (value < MinValue) ? MinValue : value;                
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            if(_isUpdating) return;
            _isUpdating = true;
                
            txtValue.Text = Value.ToString();
            lblMin.Text = MinValue.ToString();
            lblMax.Text = _maxValue.ToString();

            scrollBar.Value = (int)(scrollBar.Maximum / MaxValue * _value);
                
            _isUpdating = false;
        }

        private void scrollBar_ValueChanged(object sender, EventArgs e)
        {            
            Value = scrollBar.Value / (float)scrollBar.Maximum * MaxValue;
            if(!_isUpdating && ValueUpdated != null) ValueUpdated(this,new EventArgs());
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            float val;
            if(!float.TryParse(txtValue.Text, out val)) return;
            if(val < MinValue) return;
            if(val > MaxValue) return;

            Value = val;            
            if(!_isUpdating && ValueUpdated != null) ValueUpdated(this,new EventArgs());
        }
    }
}
