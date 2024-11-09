using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KandinskyLibrary.Model
{
    record class ModelDTO(long id, string name, double version, string type);
    record class StyleDTO(string name, string title, string titleEn, string image);
}
