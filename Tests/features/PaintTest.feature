Feature: PaintTest

Scenario: Open image, cut it and close app without applying changes.
	Given All old instances of app are closed
	    And new instance is open
    When user opens an image 'img7.jpg' from 'C:\Users\s.pogorelov\Pictures\'
