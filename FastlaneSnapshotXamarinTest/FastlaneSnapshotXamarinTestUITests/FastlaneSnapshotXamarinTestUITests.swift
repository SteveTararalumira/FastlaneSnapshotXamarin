//
//  FastlaneSnapshotXamarinTestUITests.swift
//  FastlaneSnapshotXamarinTestUITests
//
//  Created by Bohdan Hrybach on 12/21/18.
//  Copyright © 2018 Bohdan Hrybach. All rights reserved.
//

import XCTest

class FastlaneSnapshotXamarinTestUITests: XCTestCase {

    func testExample() {
        let app = XCUIApplication(bundleIdentifier: "com.bohdanhrybach.FastlaneSnapshotXamarin")
        setupSnapshot(app)
        app.activate()
        
        let chipCountTextField = app.textFields["reverseText"]
        chipCountTextField.tap()
        chipCountTextField.typeText("Fastlane snapshot with Xamarin")
        
        snapshot("01UserEntry")
        
        app.buttons["reverseButton"].tap()
        
        snapshot("02Alert")
    }

}
