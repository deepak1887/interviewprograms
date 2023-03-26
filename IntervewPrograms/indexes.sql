There are two types of Indexes in sql.
1. Clustered Indexes
	These are internally managed using B-Tree(Computed), the rows with be arranged physically in the memory in sorted order.
	Since the Indexes arrange themselves physically in the memory in sorted order, the insert/update will become slow as it must be in the sorted order.

	

2. Non Clustered Indexes
	These are not arranged physically in memory in sort order, results in fast search, inserts at the end of table.
	max 999 non clustered indexes can be created on the table.
	Example:
	create index 'Name' on 'table'('column')
	Base on the no of column on which the indexes are created, they can be classified into simple and composit indexes.
	on single column -- simple index
	on multiple column -- composit index
