using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClashLand.Core.Networking;
using ClashLand.Logic;
using ClashLand.Extensions.Binary;
using ClashLand.Extensions.List;

namespace ClashLand.Packets.Messages.Client
{

    internal class Search_Clans : Message
    {
        public Search_Clans(Device Device, Reader Reader) : base(Device, Reader)
        {
            // SearchClans.
        }

        const int m_vAllianceLimit = 40;
        int m_vAllianceOrigin;
        int m_vAllianceScore;
        int m_vMaximumAllianceMembers;
        int m_vMinimumAllianceLevel;
        int m_vMinimumAllianceMembers;
        //string m_vSearchString;
        byte m_vShowOnlyJoinableAlliances;
        int m_vWarFrequency;

        internal override void Decode()
        {
            this.m_vWarFrequency = this.Reader.ReadInt32();
            this.m_vAllianceOrigin = this.Reader.ReadInt32();
            this.m_vMinimumAllianceMembers = this.Reader.ReadInt32();
            this.m_vMaximumAllianceMembers = this.Reader.ReadInt32();
            this.m_vAllianceScore = this.Reader.ReadInt32();
            this.m_vShowOnlyJoinableAlliances = this.Reader.ReadByte();
            this.Reader.ReadInt32();
            this.m_vMinimumAllianceLevel = this.Reader.ReadInt32();
        }

        internal override void Process()
        {
            /*if (m_vSearchString.Length < 15)
            {
                //Resources.DisconnectClient(Device);
            }
            else
            {
                //List<Clans> joinableAlliances = new List<Clans>();

                //foreach (Alliance _Alliance in ResourcesManager.m_vInMemoryAlliances.Values)
                {
                    //if (_Alliance.m_vAllianceName.Contains(m_vSearchString, StringComparison.OrdinalIgnoreCase))
                    {
                        //joinableAlliances.Add(_Alliance);
                    }
                }

                //AllianceListMessage p = new AllianceListMessage(Device);
                //p.m_vAlliances = joinableAlliances;
                //p.m_vSearchString = m_vSearchString;
                //p.Send();*/
            }
        }
    }
//}