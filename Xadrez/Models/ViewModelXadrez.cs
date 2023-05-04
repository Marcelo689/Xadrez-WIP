using Pieces.Pieces;

namespace Xadrez.Models;

public class ViewModelXadrez
{
    
    public Tabuleiro Tabuleiro { get; set; }
    public ViewModelXadrez()
    {
        PreencherTabuleiro();  
    }
    public void PreencherTabuleiro()
    {
        Tabuleiro = new Tabuleiro();
        PreencherLadoSuperior();
        PreencherCelulasVazias();
        PreencherLadoInferior();
    }

    private void PreencherCelulasVazias()
    {
        var cor = Piece.WhiteColor;

        for(var linha= 2; linha < 6; linha++)
        {
            if (cor == Piece.BlackColor)
                cor = Piece.WhiteColor;
            else
                cor = Piece.BlackColor;
            for (var coluna = 0; coluna < 8; coluna++)
            {
                this.Tabuleiro.Celulas[linha][coluna].BackgroundColor = cor;

                if (cor == Piece.BlackColor)
                    cor = Piece.WhiteColor;
                else
                    cor = Piece.BlackColor; 

            }

        }
    }

    private void PreencherLadoInferior()
    {
        this.Tabuleiro.Celulas[7][0] = Piece.Instanciate<Rook>();
        this.Tabuleiro.Celulas[7][0].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[7][1] = Piece.Instanciate<Knight>();
        this.Tabuleiro.Celulas[7][1].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[7][2] = Piece.Instanciate<Bishop>();
        this.Tabuleiro.Celulas[7][2].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[7][3] = Piece.Instanciate<Queen>();
        this.Tabuleiro.Celulas[7][3].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[7][4] = Piece.Instanciate<King>();
        this.Tabuleiro.Celulas[7][4].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[7][5] = Piece.Instanciate<Bishop>();
        this.Tabuleiro.Celulas[7][5].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[7][6] = Piece.Instanciate<Knight>();
        this.Tabuleiro.Celulas[7][6].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[7][7] = Piece.Instanciate<Rook>();
        this.Tabuleiro.Celulas[7][7].BackgroundColor = Piece.BlackColor;

        //peoes/

        this.Tabuleiro.Celulas[6][0] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[6][0].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[6][1] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[6][1].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[6][2] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[6][2].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[6][3] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[6][3].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[6][4] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[6][4].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[6][5] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[6][5].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[6][6] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[6][6].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[6][7] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[6][7].BackgroundColor = Piece.WhiteColor;
    }

    private void PreencherLadoSuperior()
    {

        this.Tabuleiro.Celulas[0][0] = Piece.Instanciate<Rook>();
        this.Tabuleiro.Celulas[0][0].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[0][1] = Piece.Instanciate<Knight>();
        this.Tabuleiro.Celulas[0][1].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[0][2] = Piece.Instanciate<Bishop>();
        this.Tabuleiro.Celulas[0][2].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[0][3] = Piece.Instanciate<Queen>();
        this.Tabuleiro.Celulas[0][3].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[0][4] = Piece.Instanciate<King>();
        this.Tabuleiro.Celulas[0][4].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[0][5] = Piece.Instanciate<Bishop>();
        this.Tabuleiro.Celulas[0][5].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[0][6] = Piece.Instanciate<Knight>();
        this.Tabuleiro.Celulas[0][6].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[0][7] = Piece.Instanciate<Rook>();
        this.Tabuleiro.Celulas[0][7].BackgroundColor = Piece.WhiteColor;

        //peoes

        this.Tabuleiro.Celulas[1][0] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[1][0].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[1][1] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[1][1].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[1][2] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[1][2].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[1][3] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[1][3].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[1][4] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[1][4].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[1][5] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[1][5].BackgroundColor = Piece.BlackColor;

        this.Tabuleiro.Celulas[1][6] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[1][6].BackgroundColor = Piece.WhiteColor;

        this.Tabuleiro.Celulas[1][7] = Piece.Instanciate<Pawn>();
        this.Tabuleiro.Celulas[1][7].BackgroundColor = Piece.BlackColor;
    }

}