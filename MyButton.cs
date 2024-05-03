struct MyButton() : IView
{
    int count = 0;

    void Increment(Event e) => count++;

    public HtmlString Render() => $"""
        <button onclick="{this.Increment}">Clicks: {count}</button>
    """;
}
