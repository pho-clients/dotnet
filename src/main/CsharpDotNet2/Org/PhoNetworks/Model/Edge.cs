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
  public class Edge {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public UUID Id { get; set; }

    /// <summary>
    /// Gets or Sets Head
    /// </summary>
    [DataMember(Name="head", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head")]
    public UUID Head { get; set; }

    /// <summary>
    /// Gets or Sets Tail
    /// </summary>
    [DataMember(Name="tail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tail")]
    public UUID Tail { get; set; }

    /// <summary>
    /// Gets or Sets _Class
    /// </summary>
    [DataMember(Name="class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "class")]
    public string _Class { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Edge {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Head: ").Append(Head).Append("\n");
      sb.Append("  Tail: ").Append(Tail).Append("\n");
      sb.Append("  _Class: ").Append(_Class).Append("\n");
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
