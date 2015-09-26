namespace BalloonsPopGame.Srs.Command
{
    public interface IInputCommand
    {
        void Execute(ref char[,] playBoard, ref int userMoves);
    }
}
