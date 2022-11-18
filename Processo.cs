using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurídico.Models
{
    class Processo
    {
        public int numero { get; set; }
        public DateTime datacricao { get; set; }
        public Pessoa solicitante { get; set; }
        public Pessoa Acusado { get; set; }
        public Pedido pedido { get; set; }

        public double getvalortotalpedidos()
        {
            return 1;
        }
        public int getquantidadepedidos()
        {
            return 1;
        }
        public int distribuicaodeprocessos()
        {
            return 1;
        }
        public List<Processo> getprocessosporescritorio ()
        {
            return null;
        }
        
            
        







}
}
