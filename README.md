1. Hướng dẫn cài đặt môi trường(windows)

   - Cài đặt java JDK và thiết lập JAVA_HOME

     Download JDK 8 tại:

     `https://www.oracle.com/java/technologies/javase-jdk8-downloads.html`

     Sau đó sẽ thiết lập JAVA_HOME

     ![Search for advanced system settings](https://javatutorial.net/wp-content/uploads/2016/08/search-for-advanced-system-settings-in-windows-10.jpg)

     Under “System variables” click the “New…” button and enter JAVA_HOME as “Variable name” and the path to your Java JDK directory under “Variable value”

     ![Add JAVA_HOME as system variable](https://javatutorial.net/wp-content/uploads/2016/08/add-java_home-as-system-variable.jpg)

     ​	Update System PATH

     1. In “Environment Variables” window under “System variables” select Path

     2. Click on “Edit…”

     3. In “Edit environment variable” window click “New”

     4. Type in `%JAVA_HOME%\bin`

        ![Update system path](https://javatutorial.net/wp-content/uploads/2016/08/update-system-path-1024x524.jpg)

        Test config.

        1. Open CMD and type "javac -version" and %JAVA_HOME%
        2. This will print out the version of the java compiler if the Path variable is set correctly or *“javac is not recognized as an internal or external command…”* otherwise

   - Cài đặt ANDROID_HOME

     1. Download and set up the android SDK (need to download package manually via command line)

     2. Or download Android STUDIO from the link https://developer.android.com/studio/index.html

     3. Set Android_Home Environmental variables path to SDK location and include bin folder paths in PATH variable

        Find the folder location where you installed Android SDK

        1. The default folder location where Android SDK is installed is – C:\Users\{your username}\AppData\Local\Android\sdk. Please open this folder path and see if you have Android SDK folder in there with contents as shown below
           ![Android Environment Variables - Android SDK folder contents](http://www.automationtestinghub.com/images/android/android-sdk-folder-and-its-contents.png)

        2. Copy the SDK folder location once you find it. For us, this folder location is – C:\Users\{

        3. your username}\AppData\Local\Android\sdk
           ![image-20200325122749098](C:\Users\haing\AppData\Roaming\Typora\typora-user-images\image-20200325122749098.png)

        4. Folder locations to be added to Path variable
           %ANDROID_HOME%\platform-tools
           %ANDROID_HOME%\tools
           %ANDROID_HOME%\tools\bin

           ![Folders to be added to Path variable](http://www.automationtestinghub.com/images/android/android-folders-to-be-added-to-path-variable.png)

        5. ![image-20200325123048077](C:\Users\haing\AppData\Roaming\Typora\typora-user-images\image-20200325123048077.png)

   - Download and setup NodeJS, Npm, Appium

2. Tải và cài đặt emulator

   - Tải và cài đặt mumu & nox

3. Kết nối với emulator và viết một test script đơn giản

   - Tải và cài đặt một app đơn giản trên emulator

     Mở ứng dụng trên emulator hoặc real device, sau đó mở command line trên window và thực hiện thao tác sau để lấy được appPackage và appActivity

     ![image-20200325112449873](C:\Users\haing\AppData\Roaming\Typora\typora-user-images\image-20200325112449873.png)

   - Kết nối appium với emulator

   - Viết script

4. Tìm hiểu về các property connection

5. Hướng dẫn bắt đối tượng

Reference: 

- https://javatutorial.net/set-java-home-windows-10
- http://www.automationtestinghub.com/setup-android-environment-variables/
- 