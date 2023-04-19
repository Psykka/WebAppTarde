using Microsoft.AspNetCore.Mvc;
using WebAppTarde.Models;

namespace WebAppTarde.Controllers
{
    public class ClientController : Controller
    {
        public static List<ClientViewModel> db = new List<ClientViewModel>();

        public IActionResult List()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    ClientViewModel client = new ClientViewModel();
            //    client.Id = i;
            //    client.Nome = "Pessoa " + i;
            //    client.Telefone = "16 " + i;

            //    db.Add(client);
            //}
            return View(db);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(ClientViewModel data)
        {
            if(data.Id == 0)
            {
                int id = db.Count + 1;
                data.Id = id;
                db.Add(data);
            }
            else
            {
                int index = db.FindIndex(x => x.Id == data.Id);
                db[index] = data;
            }

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            ClientViewModel client = db.Find(x => x.Id == id);
            if(client != null) db.Remove(client);

            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            ClientViewModel client = db.Find(x => x.Id == id);

            if (client != null)
            {
                return View(client);
            }
            else
            {
                return RedirectToAction("List");
            }
        }
    }
}
