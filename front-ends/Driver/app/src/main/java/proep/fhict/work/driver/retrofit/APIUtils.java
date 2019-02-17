package proep.fhict.work.driver.retrofit;

public class APIUtils {

    private APIUtils() {}

    private static final String BASE_URL = "http://145.93.60.132:8080/client/rest/client/";

    public static APIService getAPIService() {

        return RetrofitClient.getClient(BASE_URL).create(APIService.class);
    }
}
