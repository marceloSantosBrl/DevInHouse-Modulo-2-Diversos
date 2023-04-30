namespace semana3.ex_six;

public class Rectangle
{
    private float _height;

    public float Height
    {
        get => _height;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Height), "Altura inválida");
            }
            _height = value;
        }
    }


    private float _width;

    public float Width
    {
        get => _width;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Width), "Largura inválida");
            }

            _width = value;
        }
    }
    
    public Rectangle(float height, float width)
    {
        _height = height;
        _width = width;
    }

    public float GetArea()
    {
        return _width * _height;
    }
}