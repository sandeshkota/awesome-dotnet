<h2 align="center">
  Span
</h2>

This is to compare the substring and Span behavior

## Bench mark result
![Benchmark](assets/span_benchmark.PNG)

## Memory Allocation

By using Substring method
```
private static readonly string dateText = "15 07 2021";

public (int day, int month, int year) GetDateWithString_Substring()
{
    var dayText = dateText.Substring(0, 2);
    var monthText = dateText.Substring(3, 2);
    var yearText = dateText.Substring(6);
    var day = int.Parse(dayText);
    var month = int.Parse(monthText);
    var year = int.Parse(yearText);
    return (day, month, year);
}
```
![substring](assets/GetDateWithString_Substring.png)

By using Span and Slice method
```
private static readonly string dateText = "15 07 2021";

public (int day, int month, int year) GetDateWithString_Span()
{
    ReadOnlySpan<char> dateAsSpan = dateText;
    var dayText = dateAsSpan.Slice(0, 2);
    var monthText = dateAsSpan.Slice(3, 2);
    var yearText = dateAsSpan.Slice(6);
    var day = int.Parse(dayText);
    var month = int.Parse(monthText);
    var year = int.Parse(yearText);
    return (day, month, year);
}
```
![span and splice](assets/GetDateWithString_Span.png)
