using Radio_BDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Radio_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Emissora()
        {
            return View();
        }
        public ActionResult CadastroPrograma()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GravarPrograma(Programa programa)
        {
            RadioConnection.Model.Add(programa);

            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }


            return View("Emissora");
        }
        public ActionResult ExcluirPrograma(int id)
        {
            var programa = RadioConnection.Model.Programas.FirstOrDefault(f => f.Id == id);

            RadioConnection.Model.Delete(programa);
            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }


            return View("Emissora");
        }
        public ActionResult AlterarPrograma(int id)
        {
            var programa = RadioConnection.Model.Programas.FirstOrDefault(f => f.Id == id);

            return View(programa);
        }
        [HttpPost]
        public ActionResult GravarAlterarPrograma(Programa programa)
        {

            var p = RadioConnection.Model.Programas.FirstOrDefault(f => f.Id == programa.Id);

            p.Nome_programa = programa.Nome_programa;
            p.Hora = programa.Hora;
            p.Apresentador = programa.Apresentador;
            p.Descricao = programa.Descricao;

           
            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }


            return View("Emissora");
        }

        //--------------------------------------

        public ActionResult Ouvinte()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult PedidoMusica(Pedido_musica pedido)
        {
            RadioConnection.Model.Add(pedido);

            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }


            return View("PlayList");
        }
        //______________________________________________
        public ActionResult PlayList()
        {
            return View();
        }
        public ActionResult ExcluirMusica(int id)
        {
            var musica = RadioConnection.Model.Pedido_musicas.FirstOrDefault(f => f.Id == id);

            RadioConnection.Model.Delete(musica);
            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }


            return View("PlayList");
        }

        public ActionResult TelaVotar()
        {
            return View();
        }
        public ActionResult GravarVoto(Avaliacao voto)
        {

            RadioConnection.Model.Add(voto);
          

            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }

            var listaVoto = RadioConnection.Model.Avaliacaos.OrderBy(o => o.Nota).ToList();

            return View("ListaVoto", listaVoto );
        }
       
        public ActionResult ListaVoto(Avaliacao id)
        {
            var listaVoto = RadioConnection.Model.Avaliacaos.OrderBy(o => o.Nota).ToList();

            return View(listaVoto); 
         }
       

               
        //--------------------------------------

       
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult CadastroOuvinte()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GravarOuvinte(Cadastro_usuario ouvinte)
        {
            RadioConnection.Model.Add(ouvinte);

            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }


            return View("Cadastro");
        }
        public ActionResult ExcluirOuvinte(int id)
        {
            var ouvinte = RadioConnection.Model.Cadastro_usuarios.FirstOrDefault(f => f.Id == id);

            RadioConnection.Model.Delete(ouvinte);
            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }


            return View("Cadastro");
        }
        public ActionResult AlterarOuvinte(int id)
        {
            var ouvinte = RadioConnection.Model.Cadastro_usuarios.FirstOrDefault(f => f.Id == id);

            return View(ouvinte);
        }
        public ActionResult GravarAlterarOuvinte(Cadastro_usuario ouvinte)
        {

            var ou = RadioConnection.Model.Cadastro_usuarios.FirstOrDefault(o => o.Id == ouvinte.Id);

            ou.Nome = ouvinte.Nome;
            ou.Cpf = ouvinte.Cpf;
            ou.Email = ouvinte.Email;
            ou.Senha = ouvinte.Senha;


            if (RadioConnection.Model.HasChanges)
            {
                RadioConnection.Model.SaveChanges();
            }


            return View("Cadastro");
        }
       
    }
}