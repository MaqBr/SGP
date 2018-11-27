using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.ApplicationCore.Entity
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime? DataEnvio { get; set; }
        public DateTime? DataEntrega { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemDoPedido> Itens { get; set; }
    }
}
