
namespace Petstore.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a page in Azure responses.
    /// </summary>
    /// <typeparam name="T">Type of the page content items</typeparam>
    [JsonObject]
    public class Page<T> : Microsoft.Rest.Azure.IPage<T>
    {
         /// <summary>
         /// Gets the link to the next page.
         /// </summary>
         [JsonProperty("")]
         public System.String NextPageLink { get; private set; }

         [JsonProperty("value")]
         private System.Collections.Generic.IList<T> Items{ get; set; }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         public System.Collections.Generic.IEnumerator<T> GetEnumerator()
         {
              return (Items == null) ? System.Linq.Enumerable.Empty<T>().GetEnumerator() : Items.GetEnumerator();
         }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
         {
             return GetEnumerator();
         }
    }
}

