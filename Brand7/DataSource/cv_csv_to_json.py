import csv
import json
import pyperclip

bran7_csv_file = open('Brand7.csv')
brand7_reader = csv.reader(bran7_csv_file)
# all_data = list(brand7_reader)
# print(all_data)

lst = []
for row in bran7_csv_file:
    ID, Name, KeyName, PlusName, Country, Category, Grade, Tip = row.split(',')
    lst.append("{\n'ID':%s,\n'Name':'%s',\n'KeyName':'%s',\n'PlusName':'%s',\n'Country':'%s',\n'Category':'%s',\n'Grade':%s,\n'Tip':'%s'\n}" % (
        ID, Name, KeyName, PlusName, Country, Category, Grade, Tip.replace('\n', '')))

str = ''
for row in lst:
    str += row.replace('\'', "\"\"") + ',\n'

pyperclip.copy(str)
