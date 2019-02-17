# Taxi-System
A distributed TaxiSystem similar to Uber with some Android front ends and some services

![screenshot_7](https://user-images.githubusercontent.com/17848747/52914459-ba2efb80-32c8-11e9-9e4a-3d5581fc2a8e.png)

Possible extensions from simplest to most difficult:

Fix price by distance calculator. Currently using hardcoded value in Driver App

Add Driver decision whether to use turn-by-turn outside of the app or stick with simple native line-on-map directions.

Driver view own stats from Admin app

Driver image (maybe local storage only)

Stack of Fares sometimes not coming/leaving correctly if there are multiple. Investigate in middleware/new middleware

Replace Google maps. Use of turn by turn inside other apps is not allowed(except for Uber). For a real implementation perhaps use HERE navigation. Or just stick with Google turn-by-turn outside of the app.
