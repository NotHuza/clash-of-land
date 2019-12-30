namespace ClashLand.Files.CSV_Logic
{
    using ClashLand.Files.CSV_Helpers;
    using ClashLand.Files.CSV_Reader;

    internal class Achievements : Data
    {
        public Achievements(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(_Row);
        }

        public string Name
        {
            get; set;
        }

        public int Level
        {
            get; set;
        }

        public int LevelCount
        {
            get; set;
        }

        public string TID
        {
            get; set;
        }

        public string InfoTID
        {
            get; set;
        }

        public string Action
        {
            get; set;
        }

        public int ActionCount
        {
            get; set;
        }

        public string ActionData
        {
            get; set;
        }

        public int ExpReward
        {
            get; set;
        }

        public int DiamondReward
        {
            get; set;
        }

        public string IconSWF
        {
            get; set;
        }

        public string IconExportName
        {
            get; set;
        }

        public string CompletedTID
        {
            get; set;
        }

        public bool ShowValue
        {
            get; set;
        }

        public string AndroidID
        {
            get; set;
        }

        public int UIGroup
        {
            get; set;
        }
    }
}
