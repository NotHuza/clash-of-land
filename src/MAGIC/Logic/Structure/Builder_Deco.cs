using System;
using System.Collections.Generic;
using System.Linq;
namespace ClashLand.Logic.Structure
{
    using ClashLand.Files.CSV_Helpers;
    using ClashLand.Files.CSV_Logic;
    using Newtonsoft.Json.Linq;

    internal class Builder_Deco : GameObject
    {
        public Builder_Deco(Data data, Level l) : base(data, l)
        {
        }

        internal override int ClassId => 13;

        public Decos GetDecoData => (Decos)GetData();

    }
}