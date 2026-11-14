## Meaning of Encapsulation

Encapsulation means keeping an object's internal data safe and organized. It is a basic best practice for reliability. Rather than letting other parts of the code interact directly with an object's variables, you keep the data inside the object and provide methods that control how other code can use it. This helps prevent changes in one part of the code from causing unintended side effects elsewhere.

## Benefit of Encapsulation

Encapsulation allows objects to protect their own data and functionality while keeping related logic together. It limits outside interference and helps prevent changes in one part of a program from unexpectedly affecting another part.

## Application of Encapsulation

A house thermostat provides an interface for setting the temperature while hiding its sensors and wiring. The user can adjust the temperature without needing direct access to the thermostat's internal components.

## Code Example from the Scripture Program

```csharp
public class Word
{
    private readonly string _text;
    private bool _isHidden;

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }

        return _text;
    }
}
```