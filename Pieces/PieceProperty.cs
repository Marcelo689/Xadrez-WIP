namespace Pieces
{
    public abstract class PieceProperty
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public bool IsAlive { get; set; }

        public bool TargetingSomething { get; set; }

        public int [] PieceKillingMovement { get; set; }

        public int PieceNumberTiles { get; set; }

        public int[] PieceMovements { get; set; }
        public void FillMovements(Movement[] movements)
        {
            foreach (var movement in movements)
            {
                this.PieceMovements.Append((int)movement);
            }
        }
        public enum NumberTilesMovement
        {
            One,
            Infinity
        }

        public enum KiliingMovement
        {
            Pawn,
            SameAsMovement
        }

        public enum Movement
        {
            Front,
            Diagonal,
            Horizontal,
            Vertical,
            LMovement
        }


    }
}