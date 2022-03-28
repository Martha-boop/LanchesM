using LanchesM.Context;
using LanchesM.Models;
using LanchesM.Repositories.Interfaces;

namespace LanchesM.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContex;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext appDbContex, CarrinhoCompra carrinhoCompra)
        {
            _appDbContex = appDbContex;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContex.Pedidos.Add(pedido);
            _appDbContex.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItems;

            foreach (var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetail = new PedidoDetalhe()
                {
                    Quantidade = carrinhoItem.Quantidade,
                    LancheId = carrinhoItem.Lanche.LancheId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Lanche.Preco


                };
                _appDbContex.PedidoDetalhes.Add(pedidoDetail);
            }
            _appDbContex.SaveChanges();
        }
    }
}
