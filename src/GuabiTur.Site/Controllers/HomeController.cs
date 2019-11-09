using GuabiTur.Site.Data;
using GuabiTur.Site.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GuabiTur.Site.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IPedidoRepository _pedidoRepository;
        public OperacaoService OperacaoService { get; }

        public OperacaoService OperacaoService2 { get; }

        public HomeController(IPedidoRepository pedidoRepository, OperacaoService operacaoService2, OperacaoService operacaoService)
        {
            OperacaoService2 = operacaoService2;
            OperacaoService = operacaoService;
            //_pedidoRepository = pedidoRepository;
        }

        //Exemplo mvc padrão
        //public IActionResult Index(/*[FromServices] IPedidoRepository _pedidoRepository*/)
        //{
        //    var pedido = _pedidoRepository.ObterPedido();

        //    return View();
        //}

        public string Index()
        {
            return
                "Primeira instância: " + Environment.NewLine +
                OperacaoService.Transient.OperacaoId + Environment.NewLine +
                OperacaoService.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService.SingletonInstance.OperacaoId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "Segunda instância: " + Environment.NewLine +
                OperacaoService2.Transient.OperacaoId + Environment.NewLine +
                OperacaoService2.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService2.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService2.SingletonInstance.OperacaoId + Environment.NewLine;
        }
    }
}