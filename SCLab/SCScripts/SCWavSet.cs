namespace SCLab.SCScripts
{
	public class SCWavSet
	{
		public SCWav[] Wavs { get; set; }

        public SCWavSet()
        {
            Wavs = new SCWav[512];
            for(int i = 0; i < Wavs.Length; i++)
            {
                Wavs[i] = new SCWav();
            }
        }
    }
}
