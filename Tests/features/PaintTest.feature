Feature: PaintTest

Scenario: Open image, cut it and close app without applying changes.
	Given All old instances of app were closed
	    And new instance was open
    When user opens an image 'img7.jpg' from 'C:\Users\s.pogorelov\Pictures\'
	    And user cuts all selected image area
		And user closes app without applying changes
	Then image is not changed.
