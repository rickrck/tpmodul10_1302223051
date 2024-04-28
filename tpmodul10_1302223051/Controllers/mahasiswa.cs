using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223051.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : Controller
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Ricky Renaldi", "1302223051"),
            new Mahasiswa("Nicholas Xavier Robinson Silalahi", "1302220078"),
            new Mahasiswa("Syauqi Dhiya Ulhaq", "1302220112"),
            new Mahasiswa("Ahmad Fadli Akbar", "1302220126"),
            new Mahasiswa("Syahreza Adnan Al-Azhar", "1302223041"),
            new Mahasiswa("Benedict Arvin Indra Puteprasa", "1302223136")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}