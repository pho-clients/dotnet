using System;
using System.Collections.Generic;
using RestSharp;
using Org.PhoNetworks.Client;
using Org.PhoNetworks.Model;

namespace Org.PhoNetworks.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        /// <summary>
        /// updates (or creates) an attribute Works with all entities, including nodes and edges. Given its key, updates an  attribute value, or creates it, if it doesn&#39;t yet exist. 
        /// </summary>
        /// <param name="value">The value to update the key with.</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 AddAttribute (string value);
        /// <summary>
        /// deletes an attribute Works with all entities, including nodes and edges. Given its key, deletes an  attribute. 
        /// </summary>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 DelAttribute ();
        /// <summary>
        /// deletes an entity Works with all entities, including nodes and edges.  
        /// </summary>
        /// <returns></returns>
        void DelEntity ();
        /// <summary>
        /// retrieves the edges of a node By passing in a node ID, you can fetch all the edges of the node in question; including incoming and outgoing. 
        /// </summary>
        /// <param name="uuid">The node ID</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetAllEdges (string uuid);
        /// <summary>
        /// retrieves the value of an entity attribute Attribute key must be case-sensitive. 
        /// </summary>
        /// <param name="uuid">The node ID</param>
        /// <param name="key">The attribute key</param>
        /// <returns>string</returns>
        string GetAttribute (string uuid, string key);
        /// <summary>
        /// retrieves the existing attribute keys of an entity (edge or node) Attribute keys are case-sensitive, and they will be listed in an array. 
        /// </summary>
        /// <param name="uuid">The node ID</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetAttributes (string uuid);
        /// <summary>
        /// retrieves an edge By passing in an ID, you can search for available edges in the system.  
        /// </summary>
        /// <param name="uuid">The edge ID</param>
        /// <returns>Edge</returns>
        Edge GetEdge (string uuid);
        /// <summary>
        /// retrieves the edge getter methods of a node By passing in a node UUID that exists in the database, you can fetch  the edge getter methods of the node in question. 
        /// </summary>
        /// <param name="uuid">The node ID</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetEdgeGetters (string uuid);
        /// <summary>
        /// retrieves the edge setter methods of a node By passing in a node UUID that exists in the database, you can fetch  the edge setter methods of the node in question. These setters may or  may not be formative. If they are formative, a new node is created in result. 
        /// </summary>
        /// <param name="uuid">The node ID</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetEdgeSetters (string uuid);
        /// <summary>
        /// retrieves the Graph Founder The Founder must be a \\Pho\\Framework\\Actor object.  This method returns the object type as well as object ID. 
        /// </summary>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetFounder ();
        /// <summary>
        /// retrieves the main Graph The Graph must be a \\Pho\\Lib\\Graph\\SubGraph and \\Pho\\Framework\\Graph object.  This method returns the object type as well as object ID. The Graph contains all nodes and edges in the system.  Though it is contained by Space, its one and only container. 
        /// </summary>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetGraph ();
        /// <summary>
        /// retrieves the incoming edges of a node By passing in a node ID, you can fetch  the incoming edges of the node in question. 
        /// </summary>
        /// <param name="uuid">the node ID</param>
        /// <returns>List&lt;NodeEdge&gt;</returns>
        List<NodeEdge> GetIncomingEdges (string uuid);
        /// <summary>
        /// retrieves a node By passing in an ID, you can search for available nodes in the system. Please note, this function will not return edges. This method  is  reserved for nodes only.  
        /// </summary>
        /// <param name="uuid">The node ID</param>
        /// <returns>Node</returns>
        Node GetNode (string uuid);
        /// <summary>
        /// edge getter Fetches edge results, whether as edge IDs or node IDs, depending on edge&#39;s characteristics.  
        /// </summary>
        /// <param name="uuid">The node ID</param>
        /// <param name="edge">The edge getter label</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetNodeEdge (string uuid, string edge);
        /// <summary>
        /// retrieves the outgoing edges of a node By passing in a node ID, you can fetch  the outgoing edges of the node in question. 
        /// </summary>
        /// <param name="uuid">the node ID</param>
        /// <returns>List&lt;NodeEdge&gt;</returns>
        List<NodeEdge> GetOutgoingEdges (string uuid);
        /// <summary>
        /// retrieves the Space The Space must be a \\Pho\\Lib\\Graph\\Graph object.  This method returns the object type as well as object uuid. Space always comes with the nil ID;  00000000000000000000000000000000, and under normal circumstances its class is always Pho\\Kernel\\Standards\\Space 
        /// </summary>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetSpace ();
        /// <summary>
        /// fetches entity type Possible values are; \&quot;Space\&quot;, \&quot;Node\&quot;, \&quot;Graph Node\&quot;, \&quot;Graph\&quot;, \&quot;Actor Node\&quot; \&quot;Object Node\&quot;, \&quot;Edge\&quot;, \&quot;Read Edge\&quot;, \&quot;Write Edge\&quot;, \&quot;Subscribe Edge\&quot;, \&quot;Mention Edge\&quot;, \&quot;Unidentified\&quot;. 
        /// </summary>
        /// <param name="uuid">the node</param>
        /// <returns>string</returns>
        string GetType (string uuid);
        /// <summary>
        /// creates an Actor object Fetches whatever set as \&quot;default_object\&quot;&#x3D;&gt;\&quot;actor\&quot; while determining what Actor object to construct. If it doesn&#39;t exist, uses \&quot;default_object\&quot;&#x3D;&gt;\&quot;founder\&quot; class. Otherwise fails. 
        /// </summary>
        /// <param name="param1">Actor constructor argument. More parameters may be passed via param2, param3 ... param50. </param>
        /// <returns>UUID</returns>
        UUID MakeActor (string param1);
        /// <summary>
        /// creates an edge Used to set new edges. If the edge is formative, then a node is also formed. 
        /// </summary>
        /// <param name="param1">The value to update the key with. There can be 50 of those. For example;  param1&#x3D;\&quot;value1\&quot;, param2 &#x3D;\&quot;another value\&quot; depending on the edge&#39;s default constructor variable count. </param>
        /// <returns>string</returns>
        string MakeEdge (string param1);
        /// <summary>
        /// updates (or creates) an attribute Works with all entities, including nodes and edges. Given its key, updates an  attribute value, or creates it, if it doesn&#39;t yet exist. 
        /// </summary>
        /// <param name="value">The value to update the key with.</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 SetAttribute (string value);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// updates (or creates) an attribute Works with all entities, including nodes and edges. Given its key, updates an  attribute value, or creates it, if it doesn&#39;t yet exist. 
        /// </summary>
        /// <param name="value">The value to update the key with.</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 AddAttribute (string value)
        {
            
    
            var path = "/{uuid}/attribute/{key}";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(value); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAttribute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAttribute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        /// deletes an attribute Works with all entities, including nodes and edges. Given its key, deletes an  attribute. 
        /// </summary>
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 DelAttribute ()
        {
            
    
            var path = "/{uuid}/attribute/{key}";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DelAttribute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DelAttribute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        /// deletes an entity Works with all entities, including nodes and edges.  
        /// </summary>
        /// <returns></returns>            
        public void DelEntity ()
        {
            
    
            var path = "/{uuid}";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DelEntity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DelEntity: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// retrieves the edges of a node By passing in a node ID, you can fetch all the edges of the node in question; including incoming and outgoing. 
        /// </summary>
        /// <param name="uuid">The node ID</param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 GetAllEdges (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetAllEdges");
            
    
            var path = "/{uuid}/edges/all";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllEdges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllEdges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        /// retrieves the value of an entity attribute Attribute key must be case-sensitive. 
        /// </summary>
        /// <param name="uuid">The node ID</param> 
        /// <param name="key">The attribute key</param> 
        /// <returns>string</returns>            
        public string GetAttribute (string uuid, string key)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetAttribute");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetAttribute");
            
    
            var path = "/{uuid}/attribute/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAttribute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAttribute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// retrieves the existing attribute keys of an entity (edge or node) Attribute keys are case-sensitive, and they will be listed in an array. 
        /// </summary>
        /// <param name="uuid">The node ID</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetAttributes (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetAttributes");
            
    
            var path = "/{uuid}/attributes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAttributes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAttributes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// retrieves an edge By passing in an ID, you can search for available edges in the system.  
        /// </summary>
        /// <param name="uuid">The edge ID</param> 
        /// <returns>Edge</returns>            
        public Edge GetEdge (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetEdge");
            
    
            var path = "/edge/{uuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEdge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEdge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Edge) ApiClient.Deserialize(response.Content, typeof(Edge), response.Headers);
        }
    
        /// <summary>
        /// retrieves the edge getter methods of a node By passing in a node UUID that exists in the database, you can fetch  the edge getter methods of the node in question. 
        /// </summary>
        /// <param name="uuid">The node ID</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetEdgeGetters (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetEdgeGetters");
            
    
            var path = "/{uuid}/edges/getters";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEdgeGetters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEdgeGetters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// retrieves the edge setter methods of a node By passing in a node UUID that exists in the database, you can fetch  the edge setter methods of the node in question. These setters may or  may not be formative. If they are formative, a new node is created in result. 
        /// </summary>
        /// <param name="uuid">The node ID</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetEdgeSetters (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetEdgeSetters");
            
    
            var path = "/{uuid}/edges/setters";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEdgeSetters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEdgeSetters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// retrieves the Graph Founder The Founder must be a \\Pho\\Framework\\Actor object.  This method returns the object type as well as object ID. 
        /// </summary>
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 GetFounder ()
        {
            
    
            var path = "/founder";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFounder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFounder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// retrieves the main Graph The Graph must be a \\Pho\\Lib\\Graph\\SubGraph and \\Pho\\Framework\\Graph object.  This method returns the object type as well as object ID. The Graph contains all nodes and edges in the system.  Though it is contained by Space, its one and only container. 
        /// </summary>
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetGraph ()
        {
            
    
            var path = "/graph";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGraph: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGraph: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        /// retrieves the incoming edges of a node By passing in a node ID, you can fetch  the incoming edges of the node in question. 
        /// </summary>
        /// <param name="uuid">the node ID</param> 
        /// <returns>List&lt;NodeEdge&gt;</returns>            
        public List<NodeEdge> GetIncomingEdges (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetIncomingEdges");
            
    
            var path = "/{uuid}/edges/in";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIncomingEdges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIncomingEdges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NodeEdge>) ApiClient.Deserialize(response.Content, typeof(List<NodeEdge>), response.Headers);
        }
    
        /// <summary>
        /// retrieves a node By passing in an ID, you can search for available nodes in the system. Please note, this function will not return edges. This method  is  reserved for nodes only.  
        /// </summary>
        /// <param name="uuid">The node ID</param> 
        /// <returns>Node</returns>            
        public Node GetNode (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetNode");
            
    
            var path = "/{uuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Node) ApiClient.Deserialize(response.Content, typeof(Node), response.Headers);
        }
    
        /// <summary>
        /// edge getter Fetches edge results, whether as edge IDs or node IDs, depending on edge&#39;s characteristics.  
        /// </summary>
        /// <param name="uuid">The node ID</param> 
        /// <param name="edge">The edge getter label</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetNodeEdge (string uuid, string edge)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetNodeEdge");
            
            // verify the required parameter 'edge' is set
            if (edge == null) throw new ApiException(400, "Missing required parameter 'edge' when calling GetNodeEdge");
            
    
            var path = "/{uuid}/{edge}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
path = path.Replace("{" + "edge" + "}", ApiClient.ParameterToString(edge));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeEdge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeEdge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// retrieves the outgoing edges of a node By passing in a node ID, you can fetch  the outgoing edges of the node in question. 
        /// </summary>
        /// <param name="uuid">the node ID</param> 
        /// <returns>List&lt;NodeEdge&gt;</returns>            
        public List<NodeEdge> GetOutgoingEdges (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetOutgoingEdges");
            
    
            var path = "/{uuid}/edges/out";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOutgoingEdges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOutgoingEdges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NodeEdge>) ApiClient.Deserialize(response.Content, typeof(List<NodeEdge>), response.Headers);
        }
    
        /// <summary>
        /// retrieves the Space The Space must be a \\Pho\\Lib\\Graph\\Graph object.  This method returns the object type as well as object uuid. Space always comes with the nil ID;  00000000000000000000000000000000, and under normal circumstances its class is always Pho\\Kernel\\Standards\\Space 
        /// </summary>
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 GetSpace ()
        {
            
    
            var path = "/space";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSpace: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSpace: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        /// fetches entity type Possible values are; \&quot;Space\&quot;, \&quot;Node\&quot;, \&quot;Graph Node\&quot;, \&quot;Graph\&quot;, \&quot;Actor Node\&quot; \&quot;Object Node\&quot;, \&quot;Edge\&quot;, \&quot;Read Edge\&quot;, \&quot;Write Edge\&quot;, \&quot;Subscribe Edge\&quot;, \&quot;Mention Edge\&quot;, \&quot;Unidentified\&quot;. 
        /// </summary>
        /// <param name="uuid">the node</param> 
        /// <returns>string</returns>            
        public string GetType (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling GetType");
            
    
            var path = "/{uuid}/type";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// creates an Actor object Fetches whatever set as \&quot;default_object\&quot;&#x3D;&gt;\&quot;actor\&quot; while determining what Actor object to construct. If it doesn&#39;t exist, uses \&quot;default_object\&quot;&#x3D;&gt;\&quot;founder\&quot; class. Otherwise fails. 
        /// </summary>
        /// <param name="param1">Actor constructor argument. More parameters may be passed via param2, param3 ... param50. </param> 
        /// <returns>UUID</returns>            
        public UUID MakeActor (string param1)
        {
            
    
            var path = "/actor";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(param1); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MakeActor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MakeActor: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UUID) ApiClient.Deserialize(response.Content, typeof(UUID), response.Headers);
        }
    
        /// <summary>
        /// creates an edge Used to set new edges. If the edge is formative, then a node is also formed. 
        /// </summary>
        /// <param name="param1">The value to update the key with. There can be 50 of those. For example;  param1&#x3D;\&quot;value1\&quot;, param2 &#x3D;\&quot;another value\&quot; depending on the edge&#39;s default constructor variable count. </param> 
        /// <returns>string</returns>            
        public string MakeEdge (string param1)
        {
            
    
            var path = "/{uuid}/{edge}";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(param1); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MakeEdge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MakeEdge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// updates (or creates) an attribute Works with all entities, including nodes and edges. Given its key, updates an  attribute value, or creates it, if it doesn&#39;t yet exist. 
        /// </summary>
        /// <param name="value">The value to update the key with.</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 SetAttribute (string value)
        {
            
    
            var path = "/{uuid}/attribute/{key}";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(value); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetAttribute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetAttribute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
    }
}
