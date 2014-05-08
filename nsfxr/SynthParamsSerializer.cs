using System;
using System.Text;

namespace nsfxr
{
    public static class SynthParamsSerializer
    {
        public static string ToString(this SynthParams input)
        {
            var result = new StringBuilder();
            result.Append((int)WaveShape);
            result.Append(",");
            += "," + To4DP(_attackTime) 
               + "," + To4DP(_sustainTime)
               + "," + To4DP(_sustainPunch) 
               + "," + To4DP(_decayTime)
               + "," + To4DP(_startFrequency) 
               + "," + To4DP(_minFrequency)
               + "," + To4DP(_slide) 
               + "," + To4DP(_deltaSlide)
               + "," + To4DP(_vibratoDepth) 
               + "," + To4DP(_vibratoSpeed)
               + "," + To4DP(_changeAmount)
               + "," + To4DP(_changeSpeed)
               + "," + To4DP(_squareDuty)
               + "," + To4DP(_dutySweep)
               + "," + To4DP(_repeatSpeed) 
               + "," + To4DP(_phaserOffset)
               + "," + To4DP(_phaserSweep) 
               + "," + To4DP(_lpFilterCutoff)
               + "," + To4DP(_lpFilterCutoffSweep) 
               + "," + To4DP(_lpFilterResonance)
               + "," + To4DP(_hpFilterCutoff) 
               + "," + To4DP(_hpFilterCutoffSweep)
               + "," + To4DP(_masterVolume);

            return str;
        }

        public bool SetSettingsString(string __string)
        {
            string[] values = __string.Split(new char[] { ',' });

            if (values.Length != 24)
                return false;

            waveType = UInt32.Parse(values[0]);
            attackTime = float.Parse(values[1]);
            sustainTime = float.Parse(values[2]);
            sustainPunch = float.Parse(values[3]);
            decayTime = float.Parse(values[4]);
            startFrequency = float.Parse(values[5]);
            minFrequency = float.Parse(values[6]);
            slide = float.Parse(values[7]);
            deltaSlide = float.Parse(values[8]);
            vibratoDepth = float.Parse(values[9]);
            vibratoSpeed = float.Parse(values[10]);
            changeAmount = float.Parse(values[11]);
            changeSpeed = float.Parse(values[12]);
            squareDuty = float.Parse(values[13]);
            dutySweep = float.Parse(values[14]);
            repeatSpeed = float.Parse(values[15]);
            phaserOffset = float.Parse(values[16]);
            phaserSweep = float.Parse(values[17]);
            lpFilterCutoff = float.Parse(values[18]);
            lpFilterCutoffSweep = float.Parse(values[19]);
            lpFilterResonance = float.Parse(values[20]);
            hpFilterCutoff = float.Parse(values[21]);
            hpFilterCutoffSweep = float.Parse(values[22]);
            masterVolume = float.Parse(values[23]);

            return true;
        }
    }
}