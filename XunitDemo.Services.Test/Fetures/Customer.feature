Feature: Customer
	關於顧客的資訊


Scenario: 兩個數字相加
	Given 我輸入第一個數字 1
	And 我輸入第二個數字 3
	When 我呼叫Add方法
	Then Add方法要等於 4

Scenario: 兩個數字相減
	Given 我輸入第一個數字 1
	And 我輸入第二個數字 3
	When 我呼叫Minus方法
	Then Minus方法要等於 4
