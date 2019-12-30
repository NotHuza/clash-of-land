using ClashLand.Files;
using ClashLand.Files.CSV_Logic;
using ClashLand.Logic.Enums;
using ClashLand.Logic.Structure;
using Newtonsoft.Json.Linq;

namespace ClashLand.Logic.Components
{
    internal class Combat_Component : Component
    {
        internal ConstructionItem Item;

        public Combat_Component(ConstructionItem ci) : base(ci)
        {
            this.Item = ci;

            if (ci.ClassId == 4 || ci.ClassId == 11)
            {
                var td = (Traps)ci.Data;
                if (td.HasAltMode)
                    this.AltTrapAttackMode = true;

                if (td.DirectionCount > 0)
                    this.AltDirectionMode = true;
            }
            else if (ci.ClassId == 0 || ci.ClassId == 7)
            {
                var bd = (Buildings)ci.Data;

                if (bd.AmmoCount > 0)
                    this.Ammo = bd.AmmoCount;

                if (bd.AltAttackMode)
                    this.AltAttackMode = true;

                if (bd.AimRotateStep > 0)
                    this.AimRotateStep = true;

                if (bd.VillageType != null)
                    _ = this.ActiveVillage2Layout >= 0;

                else
                    _ = this.ActiveLayout >= 0;

            }
        }

        internal override int Type => 1;
        internal int ActiveLayout = -1;
        internal int ActiveVillage2Layout = -1;
        internal int Ammo = -1;
        internal int GearUp = -1;
        internal int WallX = -1;
        internal int WallP = -1;
        internal int WallI = -1;
        internal int AimAngle;
        internal int AimAngleDraft;
        internal int TrapDirection;
        internal int TrapDirectionDraft;
        internal int TrapDirectionLayout2;
        internal int TrapDirectionLayout2Draft;
        internal int TrapDirectionLayout3;
        internal int TrapDirectionLayout3Draft;
        internal int TrapDirectionLayout4;
        internal int TrapDirectionLayout4Draft;
        internal bool AltAttackMode = false;
        internal bool AimRotateStep = false;
        internal bool AttackMode = false;
        internal bool AttackModeDraft = false;
        internal bool AltDirectionMode = false;
        internal bool AirMode = false;
        internal bool AirModeDraft = false;
        internal bool AltTrapAttackMode = false;
        internal bool NeedsRepair = true;

        internal void FillAmmo()
        {
            var ca = this.GetParent.Level.Avatar;
            var bd = (Buildings)this.GetParent.Data;
            var rd = CSV.Tables.Get(Gamefile.Resources).GetData(bd.AmmoResource);

            if (ca.HasEnoughResources(rd.GetGlobalID(), bd.AmmoCost[0]))
            {
                ca.Resources.Minus(rd.GetGlobalID(), bd.AmmoCost[0]);
                this.Ammo = bd.AmmoCount;
            }
        }

        internal override void Load(JObject jsonObject)
        {

            if (jsonObject["gear"] != null)
                this.GearUp = jsonObject["gear"].ToObject<int>();

            if (jsonObject["active_layout"] != null)
                this.ActiveLayout = jsonObject["active_layout"].ToObject<int>();

            if (jsonObject["act_l2"] != null)
                this.ActiveVillage2Layout = jsonObject["act_l2"].ToObject<int>();

            if (jsonObject["ammo"] != null)
                this.Ammo = jsonObject["ammo"].ToObject<int>();


            if (jsonObject["wX"] != null)
                this.WallX = jsonObject["wX"].ToObject<int>();

            if (jsonObject["wP"] != null)
                this.WallP = jsonObject["wP"].ToObject<int>();

            if (jsonObject["wI"] != null)
            {
                this.WallI = jsonObject["wI"].ToObject<int>();
                if (this.WallI > GetParent.Level.Avatar.Wall_Group_ID)
                    GetParent.Level.Avatar.Wall_Group_ID = this.WallI;
            }


            if (jsonObject["attack_mode"] != null)
            {
                this.AltAttackMode = true;
                this.AttackMode = jsonObject["attack_mode"].ToObject<bool>();
                this.AttackModeDraft = jsonObject["attack_mode_draft"].ToObject<bool>();
            }

            if (jsonObject["air_mode"] != null)
            {
                this.AltTrapAttackMode = true;
                this.AirMode = jsonObject["air_mode"].ToObject<bool>();
                this.AirModeDraft = jsonObject["air_mode_draft"].ToObject<bool>();
            }

            if (jsonObject["aim_angle"] != null)
            {
                this.AimRotateStep = true;
                this.AimAngle = jsonObject["aim_angle"].ToObject<int>();
                this.AimAngleDraft = jsonObject["aim_angle_draft"].ToObject<int>();
            }

            if (jsonObject["trapd"] != null)
            {
                this.AltDirectionMode = true;
                this.TrapDirection = jsonObject["trapd"].ToObject<int>();
                this.TrapDirectionDraft = jsonObject["trapd_draft"].ToObject<int>();
            }

        }

        internal override JObject Save(JObject jsonObject)
        {

            if (this.GearUp >= 0)
                jsonObject.Add("gear", this.GearUp);

            if (this.Ammo >= 0)
                jsonObject.Add("ammo", this.Ammo);

            if (this.WallX >= 0)
                jsonObject.Add("wX", this.WallX);

            if (this.WallP >= 0)
                jsonObject.Add("wP", this.WallP);

            if (this.WallI >= 0)
                jsonObject.Add("wI", this.WallI);

            if (this.AltAttackMode)
            {
                jsonObject.Add("attack_mode", this.AttackMode);
                jsonObject.Add("attack_mode_draft", this.AttackModeDraft);
            }

            if (this.AltTrapAttackMode)
            {
                jsonObject.Add("air_mode", this.AirMode);
                jsonObject.Add("air_mode_draft", this.AirModeDraft);
            }

            if (this.AimRotateStep)
            {
                jsonObject.Add("aim_angle", this.AimAngle);
                jsonObject.Add("aim_angle_draft", this.AimAngle);
            }

            if (this.AltDirectionMode)
            {
                if (this.ActiveLayout == 0) ;
                {
                    jsonObject.Add("trapd", this.TrapDirection);
                    jsonObject.Add("trapd_draft", this.TrapDirectionDraft);
                }

                if (this.ActiveLayout == 1)
                {
                    jsonObject.Add("trapd2", this.TrapDirectionLayout2);
                    jsonObject.Add("trapd_d2", this.TrapDirectionLayout2Draft);
                }

                if (this.ActiveLayout == 2)
                {
                    jsonObject.Add("trapd3", this.TrapDirectionLayout3);
                    jsonObject.Add("trapd_d3", this.TrapDirectionLayout3Draft);
                }

                if (this.ActiveLayout == 3)
                {
                    jsonObject.Add("trapd4", this.TrapDirectionLayout4);
                    jsonObject.Add("trapd_d4", this.TrapDirectionLayout4Draft);
                }

            }

            return jsonObject;
        }
    }
}