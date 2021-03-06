#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Sun Jul 15 08:14:46 2018

@author: sav
"""

from subprocess import call

empty = []
LIST_ITEMS = """
account_customizations
, activities                   
, addresses                    
, agent_contracts              
, agent_service_subscriptions  
, agents                       
, alias                        
, approval_levels              
, ar_internal_metadata         
, audit_entries                
, audit_entry_properties       
, audit_logs                   
, backofficers                 
, bank_cards                   
, banks                        
, beneficiaries                
, branch_configurations        
, branches                     
, centre                       
, client_configurations        
, client_partnerships          
, client_product_subscriptions 
, client_service_subscriptions 
, clients                      
, collection_centres           
, contacts                     
, countries                    
, currencies                   
, customer_questions           
, customers                    
, customization                
, dependent_questions          
, dependent_sections           
, device_assignments           
, devices                      
, documents                    
, donation_project_assignments 
, donation_projects            
, donors                       
, economic_details             
, email_addresses              
, employment_details           
, endorsements                 
, exchange_rates               
, external_links               
, farmer_memberships           
, farmers                      
, finger_prints                
, form_sections                
, forms                        
, geo_coordinates              
, gl_accounts                  
, gl_product_links             
, gl_reconciliations           
, group_membership             
, group_role                   
, groups                       
, identity_documents           
, journal_entries              
, journal_postings             
, languages                    
, loan_accounts                
, loan_products                
, marital_details              
, merchant_contracts           
, notes                        
, oauth_access_grants          
, oauth_access_tokens          
, oauth_applications           
, organizations                
, other_bank_account           
, partners                     
, people                       
, phone_numbers                
, pictures                     
, platform_privileges          
, privileges                   
, product_assignments          
, product_services             
, products                     
, question_answers             
, question_options             
, question_types               
, questions                    
, region_memberships           
, regional_blocs               
, regions                      
, savings_accounts             
, savings_products             
, schema_migrations            
, screen_types                 
, service_providers            
, service_providerships        
, services                     
, tasks                        
, till                         
, transaction_authorizations   
, transaction_batch_postings   
, transaction_batches          
, transaction_details          
, transaction_reports          
, transaction_states           
, transactions                 
, user_actions                 
, user_group_privileges        
, user_groups                  
, usergroup_privileges         
, users                        
, ussd_actions                 
, ussd_flows                   
, ussd_screen_options          
, ussd_screen_responses        
, ussd_screens
"""              

for item in LIST_ITEMS.split(", "):
    item.rstrip()
    item.strip(" ")
    call(f"dotnet ef dbcontext scaffold --force 'Host=nfortics-maindb.chjfoptj7ci5.eu-central-1.rds.amazonaws.com;Database=lemon_dashboard_production;Username=nforticsmaster;Password=n4orticsmaster123' Npgsql.EntityFrameworkCore.PostgreSQL -o Models -t {item}", shell=True)

print("Done")