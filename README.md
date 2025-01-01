# Image-Edge-Detection
This is the repository for Augmentus coding test assignment

# About the design
1. aim to interact with user using UI, so choose the Window Form App framework
2. the two edge detection algorithms both involve convolution operator, so extend the Bitmap class with a 2D convolution operator
3. aim to show the result in the predefined picture window, so extend the Bitmap class with a specific copy function that can resize the original image and copy to the picture window
4. when load the image, limit the image format to *.png, *.bmp and *.jpg

# Solution Architecture：
  Image-Edge-Detection/  
  │  
  ├── Bitmap/    
  │   └── ExtBitmap.cs  
  │  
  ├── Filter/  
  │   ├── FilterBase.cs  
  │   ├── NoFilter.cs  
  │   ├── PrewittFilter.cs  
  │   └── SobelFilter.cs  
  │  
  ├── UnitTest/  
  │   └── UnitTest1.cs  
  │  
  ├── Form1.cs  
  └── Program.cs  
 

# Run the solution
1. build the solution
2. run the generated application "ImageEdgeDetection.exe" or run the solution in the visual studio
3. press the "LoadImage" button to load your image
	the image format accetped is limited to *.png, *.bmp and *.jpg
4. press the arrow down button to choose the edge detection method(default is "NoFilter" which means the preview image shows the original image)
   upon you choose the edge detection method, the preview image will show the edge detection result
5. if you want to save the edge detection result, press the "SaveImage" button.
