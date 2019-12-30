/*namespace ClashLand.Packets.Debugs
{
    using ClashLand.Core;
    using ClashLand.Logic;
    using ClashLand.Logic.Manager;
    using ClashLand.Core.Networking;
    using ClashLand.Packets.Messages.Server;
    using ClashLand.Logic.Enums;

    internal class Clear_Obstacles : Debug
    {
        /// <summary>
        /// Gets a value indicating the required rank.
        /// </summary>
        /*internal override Rank RequiredRank
        {
            get
            {
                return Rank.MODS;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Clear_Obstacles"/> class.
        /// </summary>
        /// <param name="Device"></param>
        /// <param name="Parameters"></param>
        public Clear_Obstacles(params string[] Parameters) : base(Parameters)
        {
            
        }

        public object PlayerHighID { get; private set; }
        public object PlayerLowID { get; private set; }

        /// <summary>
        /// Processes this instance.
        /// </summary>
        internal override async void Process()
        {
            if (!string.IsNullOrEmpty(this.PlayerTag))
            {
                Player Player = await Resources.Accounts.LoadPlayerAsync(this.PlayerHighID, this.PlayerLowID);

                if (Player != null)
                {
                    Player.Level.GameObjectManager.GameObjects[3][0].Clear();
                    Player.Level.GameObjectManager.GameObjects[3][1].Clear();

                    if (Player.Connected)
                    {
                        new Disconnected_Message(Player.Level.GameMode.Device, 0).Send();
                    }
                }
            }
        }
    }

    internal class Disconnected_Message
    {
        private object device;
        private int v;

        public Disconnected_Message(object device, int v)
        {
            this.device = device;
            this.v = v;
        }
    }
}*/