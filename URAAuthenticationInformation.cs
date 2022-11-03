public class URAAuthenticationInformation{

    private string _AccessKey;
    private string _Result;
    private string _Status;
    private string _Message;


    public string AccessKey {
        get => _AccessKey;
        set => _AccessKey = value;
    }

    public string Result {
        get => _Result;
        set => _Result = value;
    }

    public string Status {
        get => _Status;
        set => _Status = value;
    }

        public string Message {
        get => _Message;
        set => _Message = value;
    }

    public URAAuthenticationInformation(){
        _AccessKey = "";
        _Result = "";
        _Status = "";
        _Message = "";
    }

    public URAAuthenticationInformation(string access_key, string result, string status, string message){
        _AccessKey = access_key;
        _Result = result;
        _Status = status;
        _Message = message;
    }

    public String retrieve_URA_Authentication_Token(){
        return _Result;
    }


}