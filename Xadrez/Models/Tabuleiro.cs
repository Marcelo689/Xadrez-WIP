using Pieces.Interfaces;
using static Xadrez.Models.Tabuleiro;

namespace Xadrez.Models
{
    public class Tabuleiro
    {
        public Tabuleiro()
        {
            FillCelulas();
        }
        public List<List<Celula>> Celulas { get; set; }

        public class Celula
        {
            public string BackgroundColor { get; set; }
            public bool IsEmpty { get; set; }   
            public IPiece PieceInCell { get; set; }  
        }

        public void FillCelulas()
        {
            Celulas = new List<List<Celula>>();

            for(var linha= 0; linha< 8; linha++)
            {
                Celulas.Add(new List<Celula>());    
                
                for(var coluna=0; coluna <8; coluna++)
                {
                    Celulas[linha].Add( new Celula());
                }
            }
        }
    }

    public static class Piece
    {
        public static string BlackColor = "Black";

        public static string WhiteColor = "White";
        public static Celula Instanciate<Peca>() where Peca : IPiece , new()
        {
            var celula = new Celula();
            celula.IsEmpty = false;
            celula.PieceInCell = new Peca();
            return celula;
        }
    }

}