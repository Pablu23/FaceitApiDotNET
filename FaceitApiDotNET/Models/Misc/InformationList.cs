using System.Collections;
using FaceitApiDotNET.Models.Championships;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Misc;

public class InformationList<T> : ICollection<T>
{
    [JsonProperty("end")] public int End { get; set; }

    [JsonProperty("items")] private List<T> _items { get; set; }

    [JsonProperty("start")] public int Start { get; set; }

    [JsonProperty("from")] public int From { get; set; }

    [JsonProperty("to")] public int To { get; set; }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in _items)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Clear()
    {
        _items.Clear();
    }

    public bool Contains(T item)
    {
        return _items.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        _items.CopyTo(array, arrayIndex);
    }

    public bool Remove(T item)
    {
        return _items.Remove(item);
    }

    public int Count => _items.Count;
    public bool IsReadOnly { get; }
    
}