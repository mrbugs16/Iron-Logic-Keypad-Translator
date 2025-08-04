using Xunit;
using IronLogicKeyPad;

namespace IronLogicKeypad.Tests;

public class OldPhonePadTests
{


    [Fact]
    public void E()
    {
        var input = "33#";
        var expected = "E";
        var result = OldphonePadTranslator.OldPhonePad(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void B()
    {
        var input = "227*#";
        var expected = "B";
        var result = OldphonePadTranslator.OldPhonePad(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Hello()
    {
        var input = "4433555 555666#";
        var expected = "HELLO";
        var result = OldphonePadTranslator.OldPhonePad(input);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SecretWord()
    {
        var input = "8 88777444666*664#";
        var expected = "TURING";
        var result = OldphonePadTranslator.OldPhonePad(input);
        Assert.Equal(expected, result);

    }
}
