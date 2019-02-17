package proep.fhict.work.driver.retrofit;

import java.util.List;

import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.Path;

public interface APIService {

    @GET
    Call<ResponseBody> getHello();

    @FormUrlEncoded
    @POST("logIn")
    Call<ResponseBody> logIn(@Field("email") String email, @Field("pass") String pass);
}
