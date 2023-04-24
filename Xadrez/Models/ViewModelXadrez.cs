using Pieces;

namespace Xadrez.Models;

public class ViewModelXadrez
{
    public PecasBrancas PecasBrancasObject { get; set; }
    public PecasPretas PecasPretasObject { get; set; }

    public void PreencherTabuleiro()
    {
        PecasBrancasObject = new PecasBrancas();
        PecasBrancasObject.Peoes = new List<Peao>{
            new Peao()
        };
    }

    public class PecasBrancas
    {
        public List<Peao> Peoes { get; set; }
    }

    public class PecasPretas
    {
        public List<Peao> Peoes { get; set; }
    }
}