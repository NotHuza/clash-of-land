using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Reader;

namespace ClashLand.Files.CSV_Logic
{
    internal class Effects : Data
    {
        public Effects(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(_Row);
        }

        public string Name { get; set; }
        public string SWF { get; set; }
        public string ExportName { get; set; }
        public string ParticleEmitter { get; set; }
        public string AltParticleEmitter { get; set; }
        public string EmitterDelayMs { get; set; }
        public int CameraShake { get; set; }
        public int CameraShakeTimeMS { get; set; }
        public bool CameraShakeInReplay { get; set; }
        public bool AttachToParent { get; set; }
        public bool DetachAfterStart { get; set; }
        public bool DestroyWhenParentDies { get; set; }
        public bool Looping { get; set; }
        public string IsoLayer { get; set; }
        public bool Targeted { get; set; }
        public int MaxCount { get; set; }
        public string Sound { get; set; }
        public int Volume { get; set; }
        public int MinPitch { get; set; }
        public int MaxPitch { get; set; }
        public string LowEndSound { get; set; }
        public int LowEndVolume { get; set; }
        public int LowEndMinPitch { get; set; }
        public int LowEndMaxPitch { get; set; }
        public bool StopSound { get; set; }
        public bool Beam { get; set; }
        public bool SortInFrontOfParent { get; set; }
        public string AttachLocator { get; set; }
    }
}
