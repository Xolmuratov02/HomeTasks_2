using System.Security.Cryptography;
using System.Text;

namespace N64.Identity.Infrastructure.Common.Identity.Sevices;

public class VerficationCodeGeneratorService
{
    private static string GenerateOnlyDigitCode(int length)
    {
        var code = new StringBuilder();

        for (var i = 0; i < length; i++)
        {
            code.Append(RandomNumberGenerator.GetInt32(0, 10));
        }

        return code.ToString();
    }
}