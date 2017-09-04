using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.PhoNetworks.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InlineResponse2003 {
    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public List<NodeEdge> From { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public List<NodeEdge> To { get; set; }

    /// <summary>
    /// Gets or Sets _In
    /// </summary>
    [DataMember(Name="in", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "in")]
    public List<InlineResponse2003In> _In { get; set; }

    /// <summary>
    /// Gets or Sets _Out
    /// </summary>
    [DataMember(Name="out", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "out")]
    public List<InlineResponse2003In> _Out { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse2003 {\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
      sb.Append("  _In: ").Append(_In).Append("\n");
      sb.Append("  _Out: ").Append(_Out).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
