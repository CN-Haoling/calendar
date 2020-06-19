//
//  Test.swift
//  menu
//
//  Created by ljc on 2020/5/21.
//  Copyright © 2020 ljc. All rights reserved.
//

import Foundation

class Test{
    
    static func initDB(){
        
        let sqlite = SQLiteManager.shareInstance
        
        
        if !sqlite.openDB(){
            return
        }
        
        let createSql = "CREATE TABLE IF NOT EXISTS  restaurant(name text Primary key, dishname text);"
        
        if !sqlite.execNonoQuerySQL(sql: createSql){
            sqlite.closeDB()
            return
        }
        
        let cleanAll = "DELETE FROM restaurant;"
        
        if !sqlite.execNonoQuerySQL(sql: cleanAll){
            sqlite.closeDB()
            return
        }
        
        let reset = "DELETE FROM sqlite_sequence WHERE name = 'restaurant';"
        if !sqlite.execNonoQuerySQL(sql: reset){
            sqlite.closeDB()
            return
            
        }
        
        
        let rs11 = "INSERT INTO restaurant(name,dishname) VALUES(‘全聚德’,'烤鸭');"
        
        let rs12 = "INSERT INTO restaurant(name,dishname) VALUES(‘全聚德’,'爆炒鸭肠');"
        
        let rs13 = "INSERT INTO restaurant(name,dishname) VALUES(‘全聚德’,'鸭架汤');"
        
        let rs14 = "INSERT INTO restaurant(name,dishname) VALUES(‘全聚德’,'芝麻鸭肝');"
        
        
        if !sqlite.execNonoQuerySQL(sql: rs11){
            sqlite.closeDB()
            return
        }
        
        if !sqlite.execNonoQuerySQL(sql: rs12){
            sqlite.closeDB()
            return
        }
        
        if !sqlite.execNonoQuerySQL(sql: rs13){
            sqlite.closeDB()
            return
        }
        
        if !sqlite.execNonoQuerySQL(sql: rs14){
            sqlite.closeDB()
            return
        }
        
        sqlite.closeDB()
        
    }
    
    static func Get(){
        
        let sqlite = SQLiteManager.shareInstance
        
        if !sqlite.openDB(){return}
        
        let queryResult = sqlite.execQuerySQL(sql: "SELECT * FROM restaurant;")
        
        print(queryResult!)
        
        for row in queryResult!{
            print(row["name"]!)
        }
        
        sqlite.closeDB()
        
    }
    
    
    static func GetName()->[NSString]{
        
        var info:[NSString] = []
        
        let sqlite = SQLiteManager.shareInstance
        if !sqlite.openDB(){return info}
        
        let queryResult = sqlite.execQuerySQL(sql: " SELECT name FROM restaurant;")
        
        print(queryResult!)
        
        for row in queryResult!{
            info.append(row["name"] as! NSString)
            //info.append(row["dishname"]!)
        }
        
        sqlite.closeDB()
        
        return info
        
    }
    
    
    static func GetDish()->[AnyObject]{
        
        var info:[AnyObject] = []
        
        let sqlite = SQLiteManager.shareInstance
        if !sqlite.openDB(){return info}
        
        let queryResult = sqlite.execQuerySQL(sql: " SELECT * FROM restaurant WHERE name='全聚德';")
        
        print(queryResult!)
        
        for row in queryResult!{
            //info.append(row["name"]!)
            info.append(row["dishname"]!)
        }
        
        sqlite.closeDB()
        
        return info
        
    }
    
    
    
}
