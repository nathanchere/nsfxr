using System;

namespace nsfxr
{
    public class SfxrAudioPlayer : IDisposable
    {
        public SfxrSynth Synth { get; set; }
    ;
	
        void Start() {
            //// TODO: create audio source
            //AudioSource soundSource = gameObject.AddComponent<AudioSource>();
            //soundSource.clip = new AudioClip();
            //soundSource.volume = 1f;
            //soundSource.pitch = 1f;
            //soundSource.priority = 128;
        }

        void OnAudioFilterRead(float[] __data, int __channels) {
            // Requets that sfxrSynth generates the needed audio data

            if (!_isDisposed && !_isDisposing && Synth != null) {
                bool hasMoreSamples = Synth.GenerateAudioFilterData(__data, __channels);
			
                // If no more samples are needed, there's no more need for this GameObject so schedule a destruction (cannot do this in this thread)
                if (!hasMoreSamples) _isDisposing = true; // TODO: how to implement cleanly;
            }
        }

        private bool _isDisposed = false;
        private bool _isDisposing = false;
        public void Dispose()
        {
            if(_isDisposed) return;

            _isDisposed = true;
            Synth = null; // TODO: dispose
            
        }
    }
}
