namespace Pieces
{
    public class Peao : PieceProperty
    {
        public bool FirstMove = true;
        public Peao( )
        {
            this.PieceKillingMovement = new int[] { (int) Movement.Diagonal };
            this.PieceNumberTiles     =  2;
            FillMovements(Movement.Front);
        }

        public void MakeAMove()
        {
            if(FirstMove)
            {
                FirstMove = false;
                PieceNumberTiles = 1;
            }
        }
        public void FillMovements(params Movement[] movements)
        {
            foreach (var movement in movements)
            {
                this.PieceMovements.Append((int)movement);
            }
        }

    }
}