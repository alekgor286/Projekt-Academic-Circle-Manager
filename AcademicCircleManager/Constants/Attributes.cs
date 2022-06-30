using Newtonsoft.Json;
using AcademicCircleManagerApp.Properties;
using AcademicCircleManagerApp.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademicCircleManagerApp.Constants
{
    static class Attributes
    {
        public static readonly AttributeVM[] Items;
        public static readonly AttributeVM[] TiIL;
        public static readonly AttributeVM[] IM;
        public static readonly AttributeVM[] EL;  
        public static readonly AttributeVM[] SK;  

        public static readonly Dictionary<AttributeVM[], string> SubcathegoryName;

        public static Cathegory AcademicCircle;
        public static Cathegory Skills;

        static Attributes()
        {
            var itemModels = JsonConvert.DeserializeObject<Model.Attribute[]>(Encoding.UTF8.GetString(Resources.Attributes));
            
            Items = new AttributeVM[40];
            for (int i = 0; i < 40; i++)
            {
                Items[i] = new AttributeVM(itemModels[i]);
            }

            TiIL = Items.AtIndexes(0, 1, 2, 3, 4, 5, 6, 7, 8).ToArray();
            IM = Items.AtIndexes(9, 10, 11, 12, 13).ToArray();
            EL = Items.AtIndexes(14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24).ToArray();
            SK = Items.AtIndexes(25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39).ToArray();


            SubcathegoryName = new Dictionary<AttributeVM[], string>();

            SubcathegoryName.Add(TiIL, Resources.TiILName);
            SubcathegoryName.Add(IM, Resources.IMName);
            SubcathegoryName.Add(EL, Resources.ELName);
            SubcathegoryName.Add(SK, Resources.SKName);

            AcademicCircle = new Cathegory(TiIL, IM, EL);
            Skills = new Cathegory(SK);

        }

        public class Cathegory {
            public AttributeVM[][] Subcathegories { get; }
            public Cathegory(params AttributeVM[][] subcathegories)
            {
                Subcathegories = subcathegories;
            }
        }
    }

    static class Extensions
    {
        public static IEnumerable<T> AtIndexes<T>(this IEnumerable<T> original, params int[] indexes)
        {
            T[] toReturn = new T[indexes.Length];

            for (int i = 0; i < indexes.Length; i++)
            {
                toReturn[i] = original.ElementAt(indexes[i]);
            }

            return toReturn;
        }
    }
}
