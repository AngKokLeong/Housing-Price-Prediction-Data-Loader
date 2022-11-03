// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

using Google.Cloud.Storage.V1;
using Google.Cloud.BigQuery.V2;
using System.Text;
using System.Text.Json;


using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Add("AccessKey", "");




string project_id = "";
var big_query_client = BigQueryClient.Create(project_id);
var google_cloud_storage_client = StorageClient.Create();

static async Task<URAAuthenticationInformation> Obtain_URA_Authentication_Object_Async(HttpClient client)
{
    var json = await client.GetStringAsync("https://www.ura.gov.sg/uraDataService/insertNewToken.action");
    
    var options = new JsonSerializerOptions { WriteIndented = true };
    URAAuthenticationInformation? uraAuthenticationInformationObj = JsonSerializer.Deserialize<URAAuthenticationInformation>(json);

    //suppress the null warnings
    return uraAuthenticationInformationObj!;
}


URAAuthenticationInformation uraAuthenticationInformationObj = await Obtain_URA_Authentication_Object_Async(client);


//retrieve the json data of Private Residential Property Transactions

static async Task<String> Retrieve_Private_Residential_Property_Transactions_Data_From_URA(HttpClient client){
    
}


static async Task Push_Json_Private_Residential_Property_Transactions_Data_To_Google_Cloud_Storage(StorageClient client, String project_id, URAAuthenticationInformation uraAuthenticationInformationObject)
{
    //var bucketName = Guid.NewGuid().ToString();
    //var bucket =  client.CreateBucket(project_id, bucketName);
    var bucket_list = client.ListBuckets(project_id);

    var selected_bucket = new Google.Apis.Storage.v1.Data.Bucket();
    
    foreach(var bucket in bucket_list){
        if (bucket.Name == "housing_price_prediction_bucket"){
            selected_bucket = bucket;
        }
    }
    
    
    //list the available bucket
    //client.ListBuckets(project_id).
    //get the right bucket

    //start the transfer job


    //link the bucket to bigquery table
 

    //start EDA

    
    // Upload some files
    var content = Encoding.UTF8.GetBytes("hello, world");
    var obj1 = client.UploadObject("housing_price_prediction_bucket", "private_residential_property_transaction_data.json", "application/json", new MemoryStream(content));
    //var obj2 = client.UploadObject(bucketName, "folder1/file2.txt", "text/plain", new MemoryStream(content));

    /*
    foreach (var obj in client.ListObjects(bucketName, ""))
    {
        Console.WriteLine(obj.Name);
    }
    */ 
}

//retrieve the json data from Private Non-Landed Residential Properties Median Rentals by Name

static async Task Push_Json_Private_Non_Landed_Residential_Properties_Median_Rentals_by_Name_Data_To_Google_Cloud_Storage(StorageClient client, String project_id,  URAAuthenticationInformation uraAuthenticationInformationObject)
{
    //var bucketName = Guid.NewGuid().ToString();
    //var bucket =  client.CreateBucket(project_id, bucketName);
    var bucket_list = client.ListBuckets(project_id);

    var selected_bucket = new Google.Apis.Storage.v1.Data.Bucket();
    
    foreach(var bucket in bucket_list){
        if (bucket.Name == "housing_price_prediction_bucket"){
            selected_bucket = bucket;
        }
    }
    
    
    //list the available bucket
    //client.ListBuckets(project_id).
    //get the right bucket

    //start the transfer job


    //link the bucket to bigquery table
 

    //start EDA

    
    // Upload some files
    var content = Encoding.UTF8.GetBytes("hello, world");
    var obj1 = client.UploadObject("housing_price_prediction_bucket", "file.json", "application/json", new MemoryStream(content));
    //var obj2 = client.UploadObject(bucketName, "folder1/file2.txt", "text/plain", new MemoryStream(content));

    /*
    foreach (var obj in client.ListObjects(bucketName, ""))
    {
        Console.WriteLine(obj.Name);
    }
    */ 
}


//retrieve the json data from Private Residential Properties Rental Contract


static async Task Push_Json_Private_Residential_Properties_Rental_Contract_Data_To_Google_Cloud_Storage(StorageClient client, String project_id, URAAuthenticationInformation uraAuthenticationInformationObject)
{
    //var bucketName = Guid.NewGuid().ToString();
    //var bucket =  client.CreateBucket(project_id, bucketName);
    var bucket_list = client.ListBuckets(project_id);

    var selected_bucket = new Google.Apis.Storage.v1.Data.Bucket();
    
    foreach(var bucket in bucket_list){
        if (bucket.Name == "housing_price_prediction_bucket"){
            selected_bucket = bucket;
        }
    }
    
    
    //list the available bucket
    //client.ListBuckets(project_id).
    //get the right bucket

    //start the transfer job


    //link the bucket to bigquery table
 

    //start EDA

    
    // Upload some files
    var content = Encoding.UTF8.GetBytes("hello, world");
    var obj1 = client.UploadObject("housing_price_prediction_bucket", "file.json", "application/json", new MemoryStream(content));
    //var obj2 = client.UploadObject(bucketName, "folder1/file2.txt", "text/plain", new MemoryStream(content));

    /*
    foreach (var obj in client.ListObjects(bucketName, ""))
    {
        Console.WriteLine(obj.Name);
    }
    */ 
}


//retrieve the json data from Private Residential Property Units Sold by Developers

static async Task Push_Json_Private_Residential_Property_Units_Sold_by_Developers_Data_To_Google_Cloud_Storage(StorageClient client, String project_id, URAAuthenticationInformation uraAuthenticationInformationObject)
{
    //var bucketName = Guid.NewGuid().ToString();
    //var bucket =  client.CreateBucket(project_id, bucketName);
    var bucket_list = client.ListBuckets(project_id);

    var selected_bucket = new Google.Apis.Storage.v1.Data.Bucket();
    
    foreach(var bucket in bucket_list){
        if (bucket.Name == "housing_price_prediction_bucket"){
            selected_bucket = bucket;
        }
    }
    
    
    //list the available bucket
    //client.ListBuckets(project_id).
    //get the right bucket

    //start the transfer job


    //link the bucket to bigquery table
 

    //start EDA

    
    // Upload some files
    var content = Encoding.UTF8.GetBytes("hello, world");
    var obj1 = client.UploadObject("housing_price_prediction_bucket", "file.json", "application/json", new MemoryStream(content));
    //var obj2 = client.UploadObject(bucketName, "folder1/file2.txt", "text/plain", new MemoryStream(content));

    /*
    foreach (var obj in client.ListObjects(bucketName, ""))
    {
        Console.WriteLine(obj.Name);
    }
    */ 
}

//retrieve the json data from Private Residential Projects in the Pipeline

static async Task Push_Json_Private_Residential_Projects_in_the_Pipeline_Data_To_Google_Cloud_Storage(StorageClient client, String project_id)
{
    //var bucketName = Guid.NewGuid().ToString();
    //var bucket =  client.CreateBucket(project_id, bucketName);
    var bucket_list = client.ListBuckets(project_id);

    var selected_bucket = new Google.Apis.Storage.v1.Data.Bucket();
    
    foreach(var bucket in bucket_list){
        if (bucket.Name == "housing_price_prediction_bucket"){
            selected_bucket = bucket;
        }
    }
    
    
    //list the available bucket
    //client.ListBuckets(project_id).
    //get the right bucket

    //start the transfer job


    //link the bucket to bigquery table
 

    //start EDA

    
    // Upload some files
    var content = Encoding.UTF8.GetBytes("hello, world");
    var obj1 = client.UploadObject("housing_price_prediction_bucket", "file.json", "application/json", new MemoryStream(content));
    //var obj2 = client.UploadObject(bucketName, "folder1/file2.txt", "text/plain", new MemoryStream(content));

    /*
    foreach (var obj in client.ListObjects(bucketName, ""))
    {
        Console.WriteLine(obj.Name);
    }
    */ 
}












/*
static async Task LoadURAData(HttpClient client)
{
      var json = await client.GetStringAsync(
         "https://www.ura.gov.sg/uraDataService/insertNewToken.action");



     BigQueryClient client = BigQueryClient.Create(projectId);
        var gcsURI = "gs://cloud-samples-data/bigquery/us-states/us-states.json";
        var dataset = client.GetDataset(datasetId);
        var schema = new TableSchemaBuilder {
            { "name", BigQueryDbType.String },
            { "post_abbr", BigQueryDbType.String }
        }.Build();
        TableReference destinationTableRef = dataset.GetTableReference(
            tableId: "us_states");
        // Create job configuration
        var jobOptions = new CreateLoadJobOptions()
        {
            SourceFormat = FileFormat.NewlineDelimitedJson
        };
        // Create and run job
        BigQueryJob loadJob = client.CreateLoadJob(
            sourceUri: gcsURI, destination: destinationTableRef,
            schema: schema, options: jobOptions);
        loadJob.PollUntilCompleted();  // Waits for the job to complete.
        // Display the number of rows uploaded
        BigQueryTable table = client.GetTable(destinationTableRef);
        Console.WriteLine(
            $"Loaded {table.Resource.NumRows} rows to {table.FullyQualifiedId}");

     Console.Write(json);
}

*/




//create a constant class for file content type
//create a constant class for file name of each intended API endpoints




await Push_Json_Private_Residential_Properties_Rental_Contract_Data_To_Google_Cloud_Storage(google_cloud_storage_client, project_id);



//await LoadURAData(client);
