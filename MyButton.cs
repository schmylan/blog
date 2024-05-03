struct MyButton() : IView
{
    int count = 0;

    public HtmlString Render() => $"""
        <button onclick="{this.Increment}">
            Clicks: {count}
        </button>
    """;

    void Increment(Event e)
    {
        count++;
    }
}
