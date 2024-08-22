using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStoredProcedures.Helper;

namespace TestStoredProcedures.Model
{
    public class ModelCar
    {
        public const string StatusYes = "Y";
        public const string StatusNo = "N";

        public int Id { get; }
        public string Name { get; }
        public string Code { get; }
        public DateTime CrtdDateTime { get; }
        public DateTime LupdDateTime { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; }
        public string DelStatus { get; set; }
        public DateTime DelDateTime { get; set; }

        public ModelCar(string brand, string model, DateTime manufactureDate)
        {
            string codeName = Guid.NewGuid().ToString();

            Id = 0;
            Name = codeName;
            Code = codeName;
            CrtdDateTime = HelperDateTime.GetUtcNow();
            LupdDateTime = HelperDateTime.GetUtcNow();
            Brand = brand;
            Model = model;
            ManufactureDate = manufactureDate;
            DelStatus = StatusNo;
            DelDateTime = HelperDateTime.GetDefaultDateTime();
        }

        public ModelCar UpdateModelCar(int id, string brand, string model)
        {
            Brand = brand;
            Model = model;
            LupdDateTime = DateTime.UtcNow;

            return this;
        }

        public ModelCar DeleteModelCar(int id)
        {
            LupdDateTime = DateTime.UtcNow;
            DelStatus = "Y";
            DelDateTime = DateTime.UtcNow;

            return this;
        }

        public Dictionary<string, object> ToAddDict()
        {
            return new Dictionary<string, object>
        {
            { nameof(Name), Name },
            { nameof(Code), Code },
            { nameof(CrtdDateTime), HelperDateTime.GetDateTimeInFormat(CrtdDateTime, HelperDateTime.format_yyyyMMddTHHmmss) },
            { nameof(LupdDateTime), HelperDateTime.GetDateTimeInFormat(LupdDateTime, HelperDateTime.format_yyyyMMddTHHmmss) },
            { nameof(Brand), Brand },
            { nameof(Model), Model },
            { nameof(ManufactureDate), HelperDateTime.GetDateTimeInFormat(ManufactureDate, HelperDateTime.format_yyyyMMddTHHmmss) },
            { nameof(DelStatus), DelStatus },
            { nameof(DelDateTime), HelperDateTime.GetDateTimeInFormat(DelDateTime, HelperDateTime.format_yyyyMMddTHHmmss) }
        };
        }

        public Dictionary<string, object> ToUpdateDict()
        {
            return new Dictionary<string, object>
        {
            { nameof(LupdDateTime), HelperDateTime.GetDateTimeInFormat(LupdDateTime, HelperDateTime.format_yyyyMMddTHHmmss) },
            { nameof(Brand), Brand },
            { nameof(Model), Model },
            { nameof(ManufactureDate), HelperDateTime.GetDateTimeInFormat(ManufactureDate, HelperDateTime.format_yyyyMMddTHHmmss) },
        };
        }

        public Dictionary<string, object> ToDeleteDict()
        {
            return new Dictionary<string, object>
        {
            { nameof(LupdDateTime), HelperDateTime.GetDateTimeInFormat(LupdDateTime, HelperDateTime.format_yyyyMMddTHHmmss) },
            { nameof(Brand), Brand },
            { nameof(Model), Model },
            { nameof(ManufactureDate), ManufactureDate },
            { nameof(DelStatus), DelStatus },
            { nameof(DelDateTime), HelperDateTime.GetDateTimeInFormat(DelDateTime, HelperDateTime.format_yyyyMMddTHHmmss) }
        };
        }
    }
}
