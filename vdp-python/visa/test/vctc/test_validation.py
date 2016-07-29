from visa.helpers.abstract_visa_api_client import AbstractVisaAPIClient
import unittest
'''
@author: visa
'''

class TestValidationAPI(unittest.TestCase):
    
    def setUp(self):
        self.abstract_visa_api_client = AbstractVisaAPIClient()

    def test_retrieve_list_recent_decision_records(self):
        base_uri = 'vctc/';
        resource_path = 'validation/v1/decisions/history';
        query_string = '?limit=1&page=1'
        response = self.abstract_visa_api_client.do_mutual_auth_request(base_uri + resource_path + query_string, '', 'Retrieve List of Recent Decision Records call', 'get')
        self.assertEqual(str(response.status_code) ,"200" ,"Retrieve List of Recent Decision Records test failed")
        pass