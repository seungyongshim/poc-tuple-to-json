using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using Xunit;

namespace Sample.Tests;

public record Dto
(
    IEnumerable<(string BulkId, int Price)> Results
);

public class PreludeSpec
{
    [Fact]
    //[InlineAutoData]
    public Task AddSuccess()
    {
        var dto = new Dto
        (
            new []
            {
                ("1", 2)
            }
        );

        var ret = JsonSerializer.Serialize(dto, new JsonSerializerOptions
        {
            
        });



        return Task.CompletedTask;
    }
}
