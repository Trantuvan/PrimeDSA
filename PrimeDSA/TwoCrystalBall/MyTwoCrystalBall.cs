namespace PrimeDSA.TwoCrystalBall;

public class MyTwoCrystalBall
{
    private readonly bool[] _breaks;

    public MyTwoCrystalBall(bool[] breaks)
    {
        _breaks = breaks;
    }

    public int Search()
    {
        var jumpAmt = (int)Math.Floor((double)(_breaks.Length / 2));
        var jumpIdx = jumpAmt;

        for (; jumpIdx < _breaks.Length; jumpIdx += jumpAmt)
        {
            if (_breaks[jumpIdx])
            {
                break;
            }
        }

        jumpIdx -= jumpAmt;

        for (int j = 0; j <= jumpAmt && jumpIdx < _breaks.Length; j++, jumpIdx++)
        {
            if (_breaks[jumpIdx])
            {
                return jumpIdx;
            }
        }

        return -1;
    }
}
