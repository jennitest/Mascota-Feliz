using System.Collections.Generic;
using System.collections.Generic;
{
     
}

namespace Mascotafeliz.App.persistencia
{
 public interface IRepositorioMascota
 {
     IEnumerable<Mascota> GetAllmascotas();
Mascota AddMascota(Mascota Mascota);
Mascota UpdateMascota(Mascota Mascota)
void deleteMascota(int idMascota);
Mascota getMascota(int idMascota);
 }   
}