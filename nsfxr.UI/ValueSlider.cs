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
        public ValueSlider()
        {
            InitializeComponent();
            MinValue = 0;
            MaxValue = 1;
            Value = 0.5f;
        }

        private float _value;
        private float _minValue;
        private float _maxValue;
        private bool _isUpdating;

        public float Value
        {
            get
            {
                return _value;
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

        private void UpdateUI() { 
            if(_isUpdating) return;
            _isUpdating = true;
                
            txtValue.Text = Value.ToString();
            lblMin.Text = MinValue.ToString();
            lblMax.Text = _maxValue.ToString();
            scrollBar.Value = (int)(scrollBar.Maximum / MaxValue * _value);
                
            _isUpdating = false;
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
                return _value;
            }

            set
            {
                _maxValue = (value < MinValue) ? MinValue : value;                
                UpdateUI();
            }
        }

        private void scrollBar_ValueChanged(object sender, EventArgs e)
        {
            Value = scrollBar.Value / (float)scrollBar.Maximum * MaxValue;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            float val;
            if(!float.TryParse(txtValue.Text, out val))
                Value = val;
            else            
                txtValue.Text = Value.ToString();
        }
    }
}
