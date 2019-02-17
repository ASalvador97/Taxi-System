package client.service.model;

import com.google.gson.annotations.Expose;
import com.owlike.genson.annotation.JsonProperty;

public class Client {
    @Expose(deserialize = false)
    private int id;

    private Name name;

    private String email;

    private String password;

    private String phone;

    private Address address;

    public Client(Name name, String email, String password, String phone, Address address) {
        this.name = name;
        this.email = email;
        this.password = password;
        this.phone = phone;
        this.address = address;
    }

    private Client(int id, Name name, String email, String password, String phone, Address address) {
        this.id = id;
        this.name = name;
        this.email = email;
        this.password = password;
        this.phone = phone;
        this.address = address;
    }

    public Client() {}

    public int getId() {
        return id;
    }

    public Name getName() {
        return name;
    }

    public void setName(Name name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public Address getAddress() {
        return address;
    }

    public void setAddress(Address address) {
        this.address = address;
    }

    public class Address {

        private String street;

        private int number;

        private String city;

        private String postal_code;

        public Address() { }

        public Address(String street, int number, String city, String postal_code) {
            this.street = street;
            this.number = number;
            this.city = city;
            this.postal_code = postal_code;
        }

        public String getStreet() {
            return street;
        }

        public void setStreet(String street) {
            this.street = street;
        }

        public int getNumber() {
            return number;
        }

        public void setNumber(int number) {
            this.number = number;
        }

        public String getCity() {
            return city;
        }

        public void setCity(String city) {
            this.city = city;
        }

        public String getPostal_code() {
            return postal_code;
        }

        public void setPostal_code(String postal_code) {
            this.postal_code = postal_code;
        }
    }

    public class Name {

        private String first_name;

        private String last_name;

        public Name(String first_name, String last_name) {
            this.first_name = first_name;
            this.last_name = last_name;
        }
        public String getFirst_name() {
            return first_name;
        }

        public void setFirst_name(String first_name) {
            this.first_name = first_name;
        }

        public String getLast_name() {
            return last_name;
        }

        public void setLast_name(String last_name) {
            this.last_name = last_name;
        }
    }
}
