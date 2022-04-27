using System;
using System.ComponentModel;

namespace Personas1.Domain.To.Helpers
{   
        public enum EnumTipoDocumento
        {
            [Description("CC")]
            CC = 0,
            [Description("NIT")]
            NIT = 1,
            [Description("CE")]
            CE = 2,
            [Description("TI")]
            TI = 3,
            [Description("PA")]
            PA = 4,
            [Description("RC")]
            RC = 5,
            [Description("AS")]
            AS = 6,
            [Description("MS")]
            MS = 7,
            [Description("CD")]
            CD = 8,
            [Description("NV")]
            NV = 9,
            [Description("SC")]
            SC = 10
        }

        public static class EnumExtensions
        {
            public static string Description(this Enum value)
            {
                var attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
                return attributes.Length > 0 ? attributes[0].Description : value.ToString();
            }

        }

}
