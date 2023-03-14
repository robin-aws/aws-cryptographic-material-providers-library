// Copyright Amazon.com Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0
// Do not modify this file. This file is machine generated, and any changes to it will be overwritten.
using System.Linq;
using System;
namespace AWS.Cryptography.MaterialProviders.Wrapped
{
  public static class TypeConversion
  {
    internal static AWS.Cryptography.MaterialProviders.AesWrappingAlg FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_AesWrappingAlg(Dafny.Aws.Cryptography.MaterialProviders.Types._IAesWrappingAlg value)
    {
      if (value.is_ALG__AES128__GCM__IV12__TAG16) return AWS.Cryptography.MaterialProviders.AesWrappingAlg.ALG_AES128_GCM_IV12_TAG16;
      if (value.is_ALG__AES192__GCM__IV12__TAG16) return AWS.Cryptography.MaterialProviders.AesWrappingAlg.ALG_AES192_GCM_IV12_TAG16;
      if (value.is_ALG__AES256__GCM__IV12__TAG16) return AWS.Cryptography.MaterialProviders.AesWrappingAlg.ALG_AES256_GCM_IV12_TAG16;
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.AesWrappingAlg value");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAesWrappingAlg ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_AesWrappingAlg(AWS.Cryptography.MaterialProviders.AesWrappingAlg value)
    {
      if (AWS.Cryptography.MaterialProviders.AesWrappingAlg.ALG_AES128_GCM_IV12_TAG16.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.AesWrappingAlg.create_ALG__AES128__GCM__IV12__TAG16();
      if (AWS.Cryptography.MaterialProviders.AesWrappingAlg.ALG_AES192_GCM_IV12_TAG16.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.AesWrappingAlg.create_ALG__AES192__GCM__IV12__TAG16();
      if (AWS.Cryptography.MaterialProviders.AesWrappingAlg.ALG_AES256_GCM_IV12_TAG16.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.AesWrappingAlg.create_ALG__AES256__GCM__IV12__TAG16();
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.AesWrappingAlg value");
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.AlgorithmSuiteId concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.AlgorithmSuiteId)value;
      var converted = new AWS.Cryptography.MaterialProviders.AlgorithmSuiteId(); if (value.is_ESDK)
      {
        converted.ESDK = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId__M4_ESDK(concrete.dtor_ESDK);
        return converted;
      }
      if (value.is_DBE)
      {
        converted.DBE = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId__M3_DBE(concrete.dtor_DBE);
        return converted;
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.AlgorithmSuiteId state");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(AWS.Cryptography.MaterialProviders.AlgorithmSuiteId value)
    {
      if (value.IsSetESDK())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.AlgorithmSuiteId.create_ESDK(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId__M4_ESDK(value.ESDK));
      }
      if (value.IsSetDBE())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.AlgorithmSuiteId.create_DBE(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId__M3_DBE(value.DBE));
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.AlgorithmSuiteId state");
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteInfo value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.AlgorithmSuiteInfo concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.AlgorithmSuiteInfo)value; AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo converted = new AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo(); converted.Id = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M2_id(concrete._id);
      converted.BinaryId = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M8_binaryId(concrete._binaryId);
      converted.MessageVersion = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M14_messageVersion(concrete._messageVersion);
      converted.Encrypt = (AWS.Cryptography.MaterialProviders.Encrypt)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M7_encrypt(concrete._encrypt);
      converted.Kdf = (AWS.Cryptography.MaterialProviders.DerivationAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M3_kdf(concrete._kdf);
      converted.Commitment = (AWS.Cryptography.MaterialProviders.DerivationAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M10_commitment(concrete._commitment);
      converted.Signature = (AWS.Cryptography.MaterialProviders.SignatureAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M9_signature(concrete._signature);
      converted.SymmetricSignature = (AWS.Cryptography.MaterialProviders.SymmetricSignatureAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M18_symmetricSignature(concrete._symmetricSignature);
      converted.EdkWrapping = (AWS.Cryptography.MaterialProviders.EdkWrappingAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M11_edkWrapping(concrete._edkWrapping); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteInfo ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo(AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.AlgorithmSuiteInfo(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M2_id(value.Id), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M8_binaryId(value.BinaryId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M14_messageVersion(value.MessageVersion), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M7_encrypt(value.Encrypt), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M3_kdf(value.Kdf), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M10_commitment(value.Commitment), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M9_signature(value.Signature), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M18_symmetricSignature(value.SymmetricSignature), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M11_edkWrapping(value.EdkWrapping));
    }
    internal static AWS.Cryptography.MaterialProviders.AwsCryptographicMaterialProvidersException FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S42_AwsCryptographicMaterialProvidersException(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_AwsCryptographicMaterialProvidersException value)
    {
      return new AWS.Cryptography.MaterialProviders.AwsCryptographicMaterialProvidersException(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S42_AwsCryptographicMaterialProvidersException__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_AwsCryptographicMaterialProvidersException ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S42_AwsCryptographicMaterialProvidersException(AWS.Cryptography.MaterialProviders.AwsCryptographicMaterialProvidersException value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_AwsCryptographicMaterialProvidersException(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S42_AwsCryptographicMaterialProvidersException__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.CommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CommitmentPolicy concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CommitmentPolicy)value;
      var converted = new AWS.Cryptography.MaterialProviders.CommitmentPolicy(); if (value.is_ESDK)
      {
        converted.ESDK = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy__M4_ESDK(concrete.dtor_ESDK);
        return converted;
      }
      if (value.is_DBE)
      {
        converted.DBE = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy__M3_DBE(concrete.dtor_DBE);
        return converted;
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.CommitmentPolicy state");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(AWS.Cryptography.MaterialProviders.CommitmentPolicy value)
    {
      if (value.IsSetESDK())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.CommitmentPolicy.create_ESDK(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy__M4_ESDK(value.ESDK));
      }
      if (value.IsSetDBE())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.CommitmentPolicy.create_DBE(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy__M3_DBE(value.DBE));
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.CommitmentPolicy state");
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsDiscoveryKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsDiscoveryKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsDiscoveryKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsDiscoveryKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsDiscoveryKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsDiscoveryKeyringInput(); converted.KmsClient = (Amazon.KeyManagementService.IAmazonKeyManagementService)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M9_kmsClient(concrete._kmsClient);
      if (concrete._discoveryFilter.is_Some) converted.DiscoveryFilter = (AWS.Cryptography.MaterialProviders.DiscoveryFilter)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M15_discoveryFilter(concrete._discoveryFilter);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsDiscoveryKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsDiscoveryKeyringInput value)
    {
      AWS.Cryptography.MaterialProviders.DiscoveryFilter var_discoveryFilter = value.IsSetDiscoveryFilter() ? value.DiscoveryFilter : (AWS.Cryptography.MaterialProviders.DiscoveryFilter)null;
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsDiscoveryKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M9_kmsClient(value.KmsClient), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M15_discoveryFilter(var_discoveryFilter), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsDiscoveryMultiKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsDiscoveryMultiKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsDiscoveryMultiKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsDiscoveryMultiKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsDiscoveryMultiKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsDiscoveryMultiKeyringInput(); converted.Regions = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M7_regions(concrete._regions);
      if (concrete._discoveryFilter.is_Some) converted.DiscoveryFilter = (AWS.Cryptography.MaterialProviders.DiscoveryFilter)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M15_discoveryFilter(concrete._discoveryFilter);
      if (concrete._clientSupplier.is_Some) converted.ClientSupplier = (AWS.Cryptography.MaterialProviders.IClientSupplier)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M14_clientSupplier(concrete._clientSupplier);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsDiscoveryMultiKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsDiscoveryMultiKeyringInput value)
    {
      AWS.Cryptography.MaterialProviders.DiscoveryFilter var_discoveryFilter = value.IsSetDiscoveryFilter() ? value.DiscoveryFilter : (AWS.Cryptography.MaterialProviders.DiscoveryFilter)null;
      AWS.Cryptography.MaterialProviders.IClientSupplier var_clientSupplier = value.IsSetClientSupplier() ? value.ClientSupplier : (AWS.Cryptography.MaterialProviders.IClientSupplier)null;
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsDiscoveryMultiKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M7_regions(value.Regions), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M15_discoveryFilter(var_discoveryFilter), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M14_clientSupplier(var_clientSupplier), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsHierarchicalKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsHierarchicalKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsHierarchicalKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsHierarchicalKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsHierarchicalKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsHierarchicalKeyringInput(); converted.BranchKeyId = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M11_branchKeyId(concrete._branchKeyId);
      converted.KmsKeyId = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M8_kmsKeyId(concrete._kmsKeyId);
      converted.KmsClient = (Amazon.KeyManagementService.IAmazonKeyManagementService)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M9_kmsClient(concrete._kmsClient);
      converted.DdbClient = (Amazon.DynamoDBv2.IAmazonDynamoDB)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M9_ddbClient(concrete._ddbClient);
      converted.BranchKeyStoreArn = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M17_branchKeyStoreArn(concrete._branchKeyStoreArn);
      converted.TtlSeconds = (long)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M10_ttlSeconds(concrete._ttlSeconds);
      if (concrete._maxCacheSize.is_Some) converted.MaxCacheSize = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M12_maxCacheSize(concrete._maxCacheSize);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsHierarchicalKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsHierarchicalKeyringInput value)
    {
      int? var_maxCacheSize = value.IsSetMaxCacheSize() ? value.MaxCacheSize : (int?)null;
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsHierarchicalKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M11_branchKeyId(value.BranchKeyId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M8_kmsKeyId(value.KmsKeyId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M9_kmsClient(value.KmsClient), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M9_ddbClient(value.DdbClient), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M17_branchKeyStoreArn(value.BranchKeyStoreArn), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M10_ttlSeconds(value.TtlSeconds), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M12_maxCacheSize(var_maxCacheSize), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsKeyringInput(); converted.KmsKeyId = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M8_kmsKeyId(concrete._kmsKeyId);
      converted.KmsClient = (Amazon.KeyManagementService.IAmazonKeyManagementService)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M9_kmsClient(concrete._kmsClient);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsKeyringInput value)
    {
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M8_kmsKeyId(value.KmsKeyId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M9_kmsClient(value.KmsClient), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkDiscoveryKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMrkDiscoveryKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkDiscoveryKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkDiscoveryKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkDiscoveryKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkDiscoveryKeyringInput(); converted.KmsClient = (Amazon.KeyManagementService.IAmazonKeyManagementService)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M9_kmsClient(concrete._kmsClient);
      if (concrete._discoveryFilter.is_Some) converted.DiscoveryFilter = (AWS.Cryptography.MaterialProviders.DiscoveryFilter)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M15_discoveryFilter(concrete._discoveryFilter);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M11_grantTokens(concrete._grantTokens);
      converted.Region = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M6_region(concrete._region); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMrkDiscoveryKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkDiscoveryKeyringInput value)
    {
      AWS.Cryptography.MaterialProviders.DiscoveryFilter var_discoveryFilter = value.IsSetDiscoveryFilter() ? value.DiscoveryFilter : (AWS.Cryptography.MaterialProviders.DiscoveryFilter)null;
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkDiscoveryKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M9_kmsClient(value.KmsClient), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M15_discoveryFilter(var_discoveryFilter), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M11_grantTokens(var_grantTokens), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M6_region(value.Region));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkDiscoveryMultiKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMrkDiscoveryMultiKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkDiscoveryMultiKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkDiscoveryMultiKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkDiscoveryMultiKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkDiscoveryMultiKeyringInput(); converted.Regions = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M7_regions(concrete._regions);
      if (concrete._discoveryFilter.is_Some) converted.DiscoveryFilter = (AWS.Cryptography.MaterialProviders.DiscoveryFilter)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M15_discoveryFilter(concrete._discoveryFilter);
      if (concrete._clientSupplier.is_Some) converted.ClientSupplier = (AWS.Cryptography.MaterialProviders.IClientSupplier)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M14_clientSupplier(concrete._clientSupplier);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMrkDiscoveryMultiKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkDiscoveryMultiKeyringInput value)
    {
      AWS.Cryptography.MaterialProviders.DiscoveryFilter var_discoveryFilter = value.IsSetDiscoveryFilter() ? value.DiscoveryFilter : (AWS.Cryptography.MaterialProviders.DiscoveryFilter)null;
      AWS.Cryptography.MaterialProviders.IClientSupplier var_clientSupplier = value.IsSetClientSupplier() ? value.ClientSupplier : (AWS.Cryptography.MaterialProviders.IClientSupplier)null;
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkDiscoveryMultiKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M7_regions(value.Regions), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M15_discoveryFilter(var_discoveryFilter), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M14_clientSupplier(var_clientSupplier), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMrkKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkKeyringInput(); converted.KmsKeyId = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M8_kmsKeyId(concrete._kmsKeyId);
      converted.KmsClient = (Amazon.KeyManagementService.IAmazonKeyManagementService)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M9_kmsClient(concrete._kmsClient);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMrkKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkKeyringInput value)
    {
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M8_kmsKeyId(value.KmsKeyId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M9_kmsClient(value.KmsClient), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkMultiKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMrkMultiKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkMultiKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkMultiKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkMultiKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkMultiKeyringInput(); if (concrete._generator.is_Some) converted.Generator = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M9_generator(concrete._generator);
      if (concrete._kmsKeyIds.is_Some) converted.KmsKeyIds = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M9_kmsKeyIds(concrete._kmsKeyIds);
      if (concrete._clientSupplier.is_Some) converted.ClientSupplier = (AWS.Cryptography.MaterialProviders.IClientSupplier)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M14_clientSupplier(concrete._clientSupplier);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMrkMultiKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsMrkMultiKeyringInput value)
    {
      string var_generator = value.IsSetGenerator() ? value.Generator : (string)null;
      System.Collections.Generic.List<string> var_kmsKeyIds = value.IsSetKmsKeyIds() ? value.KmsKeyIds : (System.Collections.Generic.List<string>)null;
      AWS.Cryptography.MaterialProviders.IClientSupplier var_clientSupplier = value.IsSetClientSupplier() ? value.ClientSupplier : (AWS.Cryptography.MaterialProviders.IClientSupplier)null;
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMrkMultiKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M9_generator(var_generator), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M9_kmsKeyIds(var_kmsKeyIds), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M14_clientSupplier(var_clientSupplier), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsMultiKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMultiKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMultiKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMultiKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsMultiKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsMultiKeyringInput(); if (concrete._generator.is_Some) converted.Generator = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M9_generator(concrete._generator);
      if (concrete._kmsKeyIds.is_Some) converted.KmsKeyIds = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M9_kmsKeyIds(concrete._kmsKeyIds);
      if (concrete._clientSupplier.is_Some) converted.ClientSupplier = (AWS.Cryptography.MaterialProviders.IClientSupplier)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M14_clientSupplier(concrete._clientSupplier);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsMultiKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsMultiKeyringInput value)
    {
      string var_generator = value.IsSetGenerator() ? value.Generator : (string)null;
      System.Collections.Generic.List<string> var_kmsKeyIds = value.IsSetKmsKeyIds() ? value.KmsKeyIds : (System.Collections.Generic.List<string>)null;
      AWS.Cryptography.MaterialProviders.IClientSupplier var_clientSupplier = value.IsSetClientSupplier() ? value.ClientSupplier : (AWS.Cryptography.MaterialProviders.IClientSupplier)null;
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsMultiKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M9_generator(var_generator), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M9_kmsKeyIds(var_kmsKeyIds), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M14_clientSupplier(var_clientSupplier), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateAwsKmsRsaKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsRsaKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsRsaKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsRsaKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateAwsKmsRsaKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateAwsKmsRsaKeyringInput(); if (concrete._publicKey.is_Some) converted.PublicKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M9_publicKey(concrete._publicKey);
      converted.KmsKeyId = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M8_kmsKeyId(concrete._kmsKeyId);
      converted.EncryptionAlgorithm = (Amazon.KeyManagementService.EncryptionAlgorithmSpec)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M19_encryptionAlgorithm(concrete._encryptionAlgorithm);
      if (concrete._kmsClient.is_Some) converted.KmsClient = (Amazon.KeyManagementService.IAmazonKeyManagementService)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M9_kmsClient(concrete._kmsClient);
      if (concrete._grantTokens.is_Some) converted.GrantTokens = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M11_grantTokens(concrete._grantTokens); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateAwsKmsRsaKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput(AWS.Cryptography.MaterialProviders.CreateAwsKmsRsaKeyringInput value)
    {
      System.IO.MemoryStream var_publicKey = value.IsSetPublicKey() ? value.PublicKey : (System.IO.MemoryStream)null;
      Amazon.KeyManagementService.IAmazonKeyManagementService var_kmsClient = value.IsSetKmsClient() ? value.KmsClient : (Amazon.KeyManagementService.IAmazonKeyManagementService)null;
      System.Collections.Generic.List<string> var_grantTokens = value.IsSetGrantTokens() ? value.GrantTokens : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateAwsKmsRsaKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M9_publicKey(var_publicKey), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M8_kmsKeyId(value.KmsKeyId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M19_encryptionAlgorithm(value.EncryptionAlgorithm), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M9_kmsClient(var_kmsClient), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M11_grantTokens(var_grantTokens));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateCryptographicMaterialsCacheInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateCryptographicMaterialsCacheInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateCryptographicMaterialsCacheInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateCryptographicMaterialsCacheInput)value; AWS.Cryptography.MaterialProviders.CreateCryptographicMaterialsCacheInput converted = new AWS.Cryptography.MaterialProviders.CreateCryptographicMaterialsCacheInput(); converted.EntryCapacity = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput__M13_entryCapacity(concrete._entryCapacity);
      if (concrete._entryPruningTailSize.is_Some) converted.EntryPruningTailSize = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput__M20_entryPruningTailSize(concrete._entryPruningTailSize); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateCryptographicMaterialsCacheInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput(AWS.Cryptography.MaterialProviders.CreateCryptographicMaterialsCacheInput value)
    {
      int? var_entryPruningTailSize = value.IsSetEntryPruningTailSize() ? value.EntryPruningTailSize : (int?)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateCryptographicMaterialsCacheInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput__M13_entryCapacity(value.EntryCapacity), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput__M20_entryPruningTailSize(var_entryPruningTailSize));
    }
    internal static AWS.Cryptography.MaterialProviders.ICryptographicMaterialsCache FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_CreateCryptographicMaterialsCacheOutput(Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsCache value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_CreateCryptographicMaterialsCacheOutput__M14_materialsCache(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsCache ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_CreateCryptographicMaterialsCacheOutput(AWS.Cryptography.MaterialProviders.ICryptographicMaterialsCache value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_CreateCryptographicMaterialsCacheOutput__M14_materialsCache(value);
    }
    internal static AWS.Cryptography.MaterialProviders.ICryptographicMaterialsManager FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateCryptographicMaterialsManagerOutput(Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsManager value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateCryptographicMaterialsManagerOutput__M16_materialsManager(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsManager ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateCryptographicMaterialsManagerOutput(AWS.Cryptography.MaterialProviders.ICryptographicMaterialsManager value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateCryptographicMaterialsManagerOutput__M16_materialsManager(value);
    }
    internal static AWS.Cryptography.MaterialProviders.CreateDefaultClientSupplierInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateDefaultClientSupplierInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateDefaultClientSupplierInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateDefaultClientSupplierInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateDefaultClientSupplierInput)value; AWS.Cryptography.MaterialProviders.CreateDefaultClientSupplierInput converted = new AWS.Cryptography.MaterialProviders.CreateDefaultClientSupplierInput(); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateDefaultClientSupplierInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateDefaultClientSupplierInput(AWS.Cryptography.MaterialProviders.CreateDefaultClientSupplierInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateDefaultClientSupplierInput();
    }
    internal static AWS.Cryptography.MaterialProviders.IClientSupplier FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateDefaultClientSupplierOutput(Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateDefaultClientSupplierOutput__M6_client(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateDefaultClientSupplierOutput(AWS.Cryptography.MaterialProviders.IClientSupplier value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateDefaultClientSupplierOutput__M6_client(value);
    }
    internal static AWS.Cryptography.MaterialProviders.CreateDefaultCryptographicMaterialsManagerInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S47_CreateDefaultCryptographicMaterialsManagerInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateDefaultCryptographicMaterialsManagerInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateDefaultCryptographicMaterialsManagerInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateDefaultCryptographicMaterialsManagerInput)value; AWS.Cryptography.MaterialProviders.CreateDefaultCryptographicMaterialsManagerInput converted = new AWS.Cryptography.MaterialProviders.CreateDefaultCryptographicMaterialsManagerInput(); converted.Keyring = (AWS.Cryptography.MaterialProviders.IKeyring)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S47_CreateDefaultCryptographicMaterialsManagerInput__M7_keyring(concrete._keyring); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateDefaultCryptographicMaterialsManagerInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S47_CreateDefaultCryptographicMaterialsManagerInput(AWS.Cryptography.MaterialProviders.CreateDefaultCryptographicMaterialsManagerInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateDefaultCryptographicMaterialsManagerInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S47_CreateDefaultCryptographicMaterialsManagerInput__M7_keyring(value.Keyring));
    }
    internal static AWS.Cryptography.MaterialProviders.IKeyring FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_CreateKeyringOutput(Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_CreateKeyringOutput__M7_keyring(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_CreateKeyringOutput(AWS.Cryptography.MaterialProviders.IKeyring value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_CreateKeyringOutput__M7_keyring(value);
    }
    internal static AWS.Cryptography.MaterialProviders.CreateMultiKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateMultiKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateMultiKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateMultiKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateMultiKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateMultiKeyringInput(); if (concrete._generator.is_Some) converted.Generator = (AWS.Cryptography.MaterialProviders.IKeyring)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput__M9_generator(concrete._generator);
      converted.ChildKeyrings = (System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.IKeyring>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput__M13_childKeyrings(concrete._childKeyrings); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateMultiKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput(AWS.Cryptography.MaterialProviders.CreateMultiKeyringInput value)
    {
      AWS.Cryptography.MaterialProviders.IKeyring var_generator = value.IsSetGenerator() ? value.Generator : (AWS.Cryptography.MaterialProviders.IKeyring)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateMultiKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput__M9_generator(var_generator), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput__M13_childKeyrings(value.ChildKeyrings));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateRawAesKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateRawAesKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateRawAesKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateRawAesKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateRawAesKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateRawAesKeyringInput(); converted.KeyNamespace = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M12_keyNamespace(concrete._keyNamespace);
      converted.KeyName = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M7_keyName(concrete._keyName);
      converted.WrappingKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M11_wrappingKey(concrete._wrappingKey);
      converted.WrappingAlg = (AWS.Cryptography.MaterialProviders.AesWrappingAlg)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M11_wrappingAlg(concrete._wrappingAlg); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateRawAesKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput(AWS.Cryptography.MaterialProviders.CreateRawAesKeyringInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateRawAesKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M12_keyNamespace(value.KeyNamespace), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M7_keyName(value.KeyName), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M11_wrappingKey(value.WrappingKey), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M11_wrappingAlg(value.WrappingAlg));
    }
    internal static AWS.Cryptography.MaterialProviders.CreateRawRsaKeyringInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput(Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateRawRsaKeyringInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.CreateRawRsaKeyringInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.CreateRawRsaKeyringInput)value; AWS.Cryptography.MaterialProviders.CreateRawRsaKeyringInput converted = new AWS.Cryptography.MaterialProviders.CreateRawRsaKeyringInput(); converted.KeyNamespace = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M12_keyNamespace(concrete._keyNamespace);
      converted.KeyName = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M7_keyName(concrete._keyName);
      converted.PaddingScheme = (AWS.Cryptography.MaterialProviders.PaddingScheme)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M13_paddingScheme(concrete._paddingScheme);
      if (concrete._publicKey.is_Some) converted.PublicKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M9_publicKey(concrete._publicKey);
      if (concrete._privateKey.is_Some) converted.PrivateKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M10_privateKey(concrete._privateKey); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICreateRawRsaKeyringInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput(AWS.Cryptography.MaterialProviders.CreateRawRsaKeyringInput value)
    {
      System.IO.MemoryStream var_publicKey = value.IsSetPublicKey() ? value.PublicKey : (System.IO.MemoryStream)null;
      System.IO.MemoryStream var_privateKey = value.IsSetPrivateKey() ? value.PrivateKey : (System.IO.MemoryStream)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.CreateRawRsaKeyringInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M12_keyNamespace(value.KeyNamespace), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M7_keyName(value.KeyName), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M13_paddingScheme(value.PaddingScheme), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M9_publicKey(var_publicKey), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M10_privateKey(var_privateKey));
    }
    internal static AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DBEAlgorithmSuiteId(Dafny.Aws.Cryptography.MaterialProviders.Types._IDBEAlgorithmSuiteId value)
    {
      if (value.is_ALG__AES__256__GCM__HKDF__SHA512__COMMIT__KEY__SYMSIG__HMAC__SHA384) return AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId.ALG_AES_256_GCM_HKDF_SHA512_COMMIT_KEY_SYMSIG_HMAC_SHA384;
      if (value.is_ALG__AES__256__GCM__HKDF__SHA512__COMMIT__KEY__ECDSA__P384__SYMSIG__HMAC__SHA384) return AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId.ALG_AES_256_GCM_HKDF_SHA512_COMMIT_KEY_ECDSA_P384_SYMSIG_HMAC_SHA384;
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId value");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDBEAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DBEAlgorithmSuiteId(AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId value)
    {
      if (AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId.ALG_AES_256_GCM_HKDF_SHA512_COMMIT_KEY_SYMSIG_HMAC_SHA384.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.DBEAlgorithmSuiteId.create_ALG__AES__256__GCM__HKDF__SHA512__COMMIT__KEY__SYMSIG__HMAC__SHA384();
      if (AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId.ALG_AES_256_GCM_HKDF_SHA512_COMMIT_KEY_ECDSA_P384_SYMSIG_HMAC_SHA384.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.DBEAlgorithmSuiteId.create_ALG__AES__256__GCM__HKDF__SHA512__COMMIT__KEY__ECDSA__P384__SYMSIG__HMAC__SHA384();
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId value");
    }
    internal static AWS.Cryptography.MaterialProviders.DBECommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DBECommitmentPolicy(Dafny.Aws.Cryptography.MaterialProviders.Types._IDBECommitmentPolicy value)
    {
      if (value.is_REQUIRE__ENCRYPT__REQUIRE__DECRYPT) return AWS.Cryptography.MaterialProviders.DBECommitmentPolicy.REQUIRE_ENCRYPT_REQUIRE_DECRYPT;
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.DBECommitmentPolicy value");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDBECommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DBECommitmentPolicy(AWS.Cryptography.MaterialProviders.DBECommitmentPolicy value)
    {
      if (AWS.Cryptography.MaterialProviders.DBECommitmentPolicy.REQUIRE_ENCRYPT_REQUIRE_DECRYPT.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.DBECommitmentPolicy.create();
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.DBECommitmentPolicy value");
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptionMaterials concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptionMaterials)value; AWS.Cryptography.MaterialProviders.DecryptionMaterials converted = new AWS.Cryptography.MaterialProviders.DecryptionMaterials(); converted.AlgorithmSuite = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M14_algorithmSuite(concrete._algorithmSuite);
      converted.EncryptionContext = (System.Collections.Generic.Dictionary<string, string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M17_encryptionContext(concrete._encryptionContext);
      converted.RequiredEncryptionContextKeys = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M29_requiredEncryptionContextKeys(concrete._requiredEncryptionContextKeys);
      if (concrete._plaintextDataKey.is_Some) converted.PlaintextDataKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M16_plaintextDataKey(concrete._plaintextDataKey);
      if (concrete._verificationKey.is_Some) converted.VerificationKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M15_verificationKey(concrete._verificationKey);
      if (concrete._symmetricSigningKey.is_Some) converted.SymmetricSigningKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M19_symmetricSigningKey(concrete._symmetricSigningKey); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(AWS.Cryptography.MaterialProviders.DecryptionMaterials value)
    {
      System.IO.MemoryStream var_plaintextDataKey = value.IsSetPlaintextDataKey() ? value.PlaintextDataKey : (System.IO.MemoryStream)null;
      System.IO.MemoryStream var_verificationKey = value.IsSetVerificationKey() ? value.VerificationKey : (System.IO.MemoryStream)null;
      System.IO.MemoryStream var_symmetricSigningKey = value.IsSetSymmetricSigningKey() ? value.SymmetricSigningKey : (System.IO.MemoryStream)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptionMaterials(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M14_algorithmSuite(value.AlgorithmSuite), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M17_encryptionContext(value.EncryptionContext), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M29_requiredEncryptionContextKeys(value.RequiredEncryptionContextKeys), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M16_plaintextDataKey(var_plaintextDataKey), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M15_verificationKey(var_verificationKey), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M19_symmetricSigningKey(var_symmetricSigningKey));
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptMaterialsInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptMaterialsInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptMaterialsInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptMaterialsInput)value; AWS.Cryptography.MaterialProviders.DecryptMaterialsInput converted = new AWS.Cryptography.MaterialProviders.DecryptMaterialsInput(); converted.AlgorithmSuiteId = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M16_algorithmSuiteId(concrete._algorithmSuiteId);
      converted.CommitmentPolicy = (AWS.Cryptography.MaterialProviders.CommitmentPolicy)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M16_commitmentPolicy(concrete._commitmentPolicy);
      converted.EncryptedDataKeys = (System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M17_encryptedDataKeys(concrete._encryptedDataKeys);
      converted.EncryptionContext = (System.Collections.Generic.Dictionary<string, string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M17_encryptionContext(concrete._encryptionContext);
      if (concrete._reproducedEncryptionContext.is_Some) converted.ReproducedEncryptionContext = (System.Collections.Generic.Dictionary<string, string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M27_reproducedEncryptionContext(concrete._reproducedEncryptionContext); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptMaterialsInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput(AWS.Cryptography.MaterialProviders.DecryptMaterialsInput value)
    {
      System.Collections.Generic.Dictionary<string, string> var_reproducedEncryptionContext = value.IsSetReproducedEncryptionContext() ? value.ReproducedEncryptionContext : (System.Collections.Generic.Dictionary<string, string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptMaterialsInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M16_algorithmSuiteId(value.AlgorithmSuiteId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M16_commitmentPolicy(value.CommitmentPolicy), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M17_encryptedDataKeys(value.EncryptedDataKeys), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M17_encryptionContext(value.EncryptionContext), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M27_reproducedEncryptionContext(var_reproducedEncryptionContext));
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptMaterialsOutput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S22_DecryptMaterialsOutput(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptMaterialsOutput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptMaterialsOutput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptMaterialsOutput)value; AWS.Cryptography.MaterialProviders.DecryptMaterialsOutput converted = new AWS.Cryptography.MaterialProviders.DecryptMaterialsOutput(); converted.DecryptionMaterials = (AWS.Cryptography.MaterialProviders.DecryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S22_DecryptMaterialsOutput__M19_decryptionMaterials(concrete._decryptionMaterials); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptMaterialsOutput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S22_DecryptMaterialsOutput(AWS.Cryptography.MaterialProviders.DecryptMaterialsOutput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.DecryptMaterialsOutput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S22_DecryptMaterialsOutput__M19_decryptionMaterials(value.DecryptionMaterials));
    }
    internal static AWS.Cryptography.MaterialProviders.DeleteCacheEntryInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DeleteCacheEntryInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IDeleteCacheEntryInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.DeleteCacheEntryInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.DeleteCacheEntryInput)value; AWS.Cryptography.MaterialProviders.DeleteCacheEntryInput converted = new AWS.Cryptography.MaterialProviders.DeleteCacheEntryInput(); converted.Identifier = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DeleteCacheEntryInput__M10_identifier(concrete._identifier); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDeleteCacheEntryInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DeleteCacheEntryInput(AWS.Cryptography.MaterialProviders.DeleteCacheEntryInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.DeleteCacheEntryInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DeleteCacheEntryInput__M10_identifier(value.Identifier));
    }
    internal static AWS.Cryptography.MaterialProviders.DerivationAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.DerivationAlgorithm concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.DerivationAlgorithm)value;
      var converted = new AWS.Cryptography.MaterialProviders.DerivationAlgorithm(); if (value.is_HKDF)
      {
        converted.HKDF = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M4_HKDF(concrete.dtor_HKDF);
        return converted;
      }
      if (value.is_IDENTITY)
      {
        converted.IDENTITY = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M8_IDENTITY(concrete.dtor_IDENTITY);
        return converted;
      }
      if (value.is_None)
      {
        converted.None = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M4_None(concrete.dtor_None);
        return converted;
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.DerivationAlgorithm state");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(AWS.Cryptography.MaterialProviders.DerivationAlgorithm value)
    {
      if (value.IsSetHKDF())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.DerivationAlgorithm.create_HKDF(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M4_HKDF(value.HKDF));
      }
      if (value.IsSetIDENTITY())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.DerivationAlgorithm.create_IDENTITY(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M8_IDENTITY(value.IDENTITY));
      }
      if (value.IsSetNone())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.DerivationAlgorithm.create_None(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M4_None(value.None));
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.DerivationAlgorithm state");
    }
    internal static AWS.Cryptography.MaterialProviders.EdkWrappingAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm(Dafny.Aws.Cryptography.MaterialProviders.Types._IEdkWrappingAlgorithm value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.EdkWrappingAlgorithm concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.EdkWrappingAlgorithm)value;
      var converted = new AWS.Cryptography.MaterialProviders.EdkWrappingAlgorithm(); if (value.is_DIRECT__KEY__WRAPPING)
      {
        converted.DIRECT__KEY__WRAPPING = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm__M19_DIRECT_KEY_WRAPPING(concrete.dtor_DIRECT__KEY__WRAPPING);
        return converted;
      }
      if (value.is_IntermediateKeyWrapping)
      {
        converted.IntermediateKeyWrapping = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm__M23_IntermediateKeyWrapping(concrete.dtor_IntermediateKeyWrapping);
        return converted;
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.EdkWrappingAlgorithm state");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEdkWrappingAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm(AWS.Cryptography.MaterialProviders.EdkWrappingAlgorithm value)
    {
      if (value.IsSetDIRECT__KEY__WRAPPING())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.EdkWrappingAlgorithm.create_DIRECT__KEY__WRAPPING(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm__M19_DIRECT_KEY_WRAPPING(value.DIRECT__KEY__WRAPPING));
      }
      if (value.IsSetIntermediateKeyWrapping())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.EdkWrappingAlgorithm.create_IntermediateKeyWrapping(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm__M23_IntermediateKeyWrapping(value.IntermediateKeyWrapping));
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.EdkWrappingAlgorithm state");
    }
    internal static AWS.Cryptography.MaterialProviders.Encrypt FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncrypt value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.Encrypt concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.Encrypt)value;
      var converted = new AWS.Cryptography.MaterialProviders.Encrypt(); if (value.is_AES__GCM)
      {
        converted.AES__GCM = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt__M7_AES_GCM(concrete.dtor_AES__GCM);
        return converted;
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.Encrypt state");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncrypt ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt(AWS.Cryptography.MaterialProviders.Encrypt value)
    {
      if (value.IsSetAES__GCM())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.Encrypt.create(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt__M7_AES_GCM(value.AES__GCM));
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.Encrypt state");
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.EncryptionMaterials concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.EncryptionMaterials)value; AWS.Cryptography.MaterialProviders.EncryptionMaterials converted = new AWS.Cryptography.MaterialProviders.EncryptionMaterials(); converted.AlgorithmSuite = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M14_algorithmSuite(concrete._algorithmSuite);
      converted.EncryptionContext = (System.Collections.Generic.Dictionary<string, string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M17_encryptionContext(concrete._encryptionContext);
      converted.EncryptedDataKeys = (System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M17_encryptedDataKeys(concrete._encryptedDataKeys);
      converted.RequiredEncryptionContextKeys = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M29_requiredEncryptionContextKeys(concrete._requiredEncryptionContextKeys);
      if (concrete._plaintextDataKey.is_Some) converted.PlaintextDataKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M16_plaintextDataKey(concrete._plaintextDataKey);
      if (concrete._signingKey.is_Some) converted.SigningKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M10_signingKey(concrete._signingKey);
      if (concrete._symmetricSigningKeys.is_Some) converted.SymmetricSigningKeys = (System.Collections.Generic.List<System.IO.MemoryStream>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M20_symmetricSigningKeys(concrete._symmetricSigningKeys); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(AWS.Cryptography.MaterialProviders.EncryptionMaterials value)
    {
      System.IO.MemoryStream var_plaintextDataKey = value.IsSetPlaintextDataKey() ? value.PlaintextDataKey : (System.IO.MemoryStream)null;
      System.IO.MemoryStream var_signingKey = value.IsSetSigningKey() ? value.SigningKey : (System.IO.MemoryStream)null;
      System.Collections.Generic.List<System.IO.MemoryStream> var_symmetricSigningKeys = value.IsSetSymmetricSigningKeys() ? value.SymmetricSigningKeys : (System.Collections.Generic.List<System.IO.MemoryStream>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.EncryptionMaterials(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M14_algorithmSuite(value.AlgorithmSuite), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M17_encryptionContext(value.EncryptionContext), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M17_encryptedDataKeys(value.EncryptedDataKeys), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M29_requiredEncryptionContextKeys(value.RequiredEncryptionContextKeys), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M16_plaintextDataKey(var_plaintextDataKey), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M10_signingKey(var_signingKey), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M20_symmetricSigningKeys(var_symmetricSigningKeys));
    }
    internal static AWS.Cryptography.MaterialProviders.EntryAlreadyExists FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_EntryAlreadyExists(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_EntryAlreadyExists value)
    {
      return new AWS.Cryptography.MaterialProviders.EntryAlreadyExists(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_EntryAlreadyExists__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_EntryAlreadyExists ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_EntryAlreadyExists(AWS.Cryptography.MaterialProviders.EntryAlreadyExists value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_EntryAlreadyExists(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_EntryAlreadyExists__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.EntryDoesNotExist FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EntryDoesNotExist(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_EntryDoesNotExist value)
    {
      return new AWS.Cryptography.MaterialProviders.EntryDoesNotExist(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EntryDoesNotExist__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_EntryDoesNotExist ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EntryDoesNotExist(AWS.Cryptography.MaterialProviders.EntryDoesNotExist value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_EntryDoesNotExist(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EntryDoesNotExist__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_ESDKAlgorithmSuiteId(Dafny.Aws.Cryptography.MaterialProviders.Types._IESDKAlgorithmSuiteId value)
    {
      if (value.is_ALG__AES__128__GCM__IV12__TAG16__NO__KDF) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_128_GCM_IV12_TAG16_NO_KDF;
      if (value.is_ALG__AES__192__GCM__IV12__TAG16__NO__KDF) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_192_GCM_IV12_TAG16_NO_KDF;
      if (value.is_ALG__AES__256__GCM__IV12__TAG16__NO__KDF) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_IV12_TAG16_NO_KDF;
      if (value.is_ALG__AES__128__GCM__IV12__TAG16__HKDF__SHA256) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_128_GCM_IV12_TAG16_HKDF_SHA256;
      if (value.is_ALG__AES__192__GCM__IV12__TAG16__HKDF__SHA256) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_192_GCM_IV12_TAG16_HKDF_SHA256;
      if (value.is_ALG__AES__256__GCM__IV12__TAG16__HKDF__SHA256) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_IV12_TAG16_HKDF_SHA256;
      if (value.is_ALG__AES__128__GCM__IV12__TAG16__HKDF__SHA256__ECDSA__P256) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_128_GCM_IV12_TAG16_HKDF_SHA256_ECDSA_P256;
      if (value.is_ALG__AES__192__GCM__IV12__TAG16__HKDF__SHA384__ECDSA__P384) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_192_GCM_IV12_TAG16_HKDF_SHA384_ECDSA_P384;
      if (value.is_ALG__AES__256__GCM__IV12__TAG16__HKDF__SHA384__ECDSA__P384) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_IV12_TAG16_HKDF_SHA384_ECDSA_P384;
      if (value.is_ALG__AES__256__GCM__HKDF__SHA512__COMMIT__KEY) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_HKDF_SHA512_COMMIT_KEY;
      if (value.is_ALG__AES__256__GCM__HKDF__SHA512__COMMIT__KEY__ECDSA__P384) return AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_HKDF_SHA512_COMMIT_KEY_ECDSA_P384;
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId value");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IESDKAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_ESDKAlgorithmSuiteId(AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId value)
    {
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_128_GCM_IV12_TAG16_NO_KDF.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__128__GCM__IV12__TAG16__NO__KDF();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_192_GCM_IV12_TAG16_NO_KDF.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__192__GCM__IV12__TAG16__NO__KDF();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_IV12_TAG16_NO_KDF.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__256__GCM__IV12__TAG16__NO__KDF();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_128_GCM_IV12_TAG16_HKDF_SHA256.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__128__GCM__IV12__TAG16__HKDF__SHA256();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_192_GCM_IV12_TAG16_HKDF_SHA256.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__192__GCM__IV12__TAG16__HKDF__SHA256();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_IV12_TAG16_HKDF_SHA256.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__256__GCM__IV12__TAG16__HKDF__SHA256();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_128_GCM_IV12_TAG16_HKDF_SHA256_ECDSA_P256.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__128__GCM__IV12__TAG16__HKDF__SHA256__ECDSA__P256();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_192_GCM_IV12_TAG16_HKDF_SHA384_ECDSA_P384.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__192__GCM__IV12__TAG16__HKDF__SHA384__ECDSA__P384();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_IV12_TAG16_HKDF_SHA384_ECDSA_P384.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__256__GCM__IV12__TAG16__HKDF__SHA384__ECDSA__P384();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_HKDF_SHA512_COMMIT_KEY.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__256__GCM__HKDF__SHA512__COMMIT__KEY();
      if (AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId.ALG_AES_256_GCM_HKDF_SHA512_COMMIT_KEY_ECDSA_P384.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKAlgorithmSuiteId.create_ALG__AES__256__GCM__HKDF__SHA512__COMMIT__KEY__ECDSA__P384();
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId value");
    }
    internal static AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_ESDKCommitmentPolicy(Dafny.Aws.Cryptography.MaterialProviders.Types._IESDKCommitmentPolicy value)
    {
      if (value.is_FORBID__ENCRYPT__ALLOW__DECRYPT) return AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy.FORBID_ENCRYPT_ALLOW_DECRYPT;
      if (value.is_REQUIRE__ENCRYPT__ALLOW__DECRYPT) return AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy.REQUIRE_ENCRYPT_ALLOW_DECRYPT;
      if (value.is_REQUIRE__ENCRYPT__REQUIRE__DECRYPT) return AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy.REQUIRE_ENCRYPT_REQUIRE_DECRYPT;
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy value");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IESDKCommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_ESDKCommitmentPolicy(AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy value)
    {
      if (AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy.FORBID_ENCRYPT_ALLOW_DECRYPT.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKCommitmentPolicy.create_FORBID__ENCRYPT__ALLOW__DECRYPT();
      if (AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy.REQUIRE_ENCRYPT_ALLOW_DECRYPT.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKCommitmentPolicy.create_REQUIRE__ENCRYPT__ALLOW__DECRYPT();
      if (AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy.REQUIRE_ENCRYPT_REQUIRE_DECRYPT.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.ESDKCommitmentPolicy.create_REQUIRE__ENCRYPT__REQUIRE__DECRYPT();
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy value");
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_GetAlgorithmSuiteInfoInput(Dafny.ISequence<byte> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_GetAlgorithmSuiteInfoInput__M8_binaryId(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_GetAlgorithmSuiteInfoInput(System.IO.MemoryStream value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_GetAlgorithmSuiteInfoInput__M8_binaryId(value);
    }
    internal static AWS.Cryptography.MaterialProviders.GetCacheEntryInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IGetCacheEntryInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.GetCacheEntryInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.GetCacheEntryInput)value; AWS.Cryptography.MaterialProviders.GetCacheEntryInput converted = new AWS.Cryptography.MaterialProviders.GetCacheEntryInput(); converted.Identifier = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput__M10_identifier(concrete._identifier);
      if (concrete._bytesUsed.is_Some) converted.BytesUsed = (long)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput__M9_bytesUsed(concrete._bytesUsed); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IGetCacheEntryInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput(AWS.Cryptography.MaterialProviders.GetCacheEntryInput value)
    {
      long? var_bytesUsed = value.IsSetBytesUsed() ? value.BytesUsed : (long?)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.GetCacheEntryInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput__M10_identifier(value.Identifier), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput__M9_bytesUsed(var_bytesUsed));
    }
    internal static AWS.Cryptography.MaterialProviders.GetCacheEntryOutput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput(Dafny.Aws.Cryptography.MaterialProviders.Types._IGetCacheEntryOutput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.GetCacheEntryOutput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.GetCacheEntryOutput)value; AWS.Cryptography.MaterialProviders.GetCacheEntryOutput converted = new AWS.Cryptography.MaterialProviders.GetCacheEntryOutput(); converted.Materials = (AWS.Cryptography.MaterialProviders.Materials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M9_materials(concrete._materials);
      converted.CreationTime = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M12_creationTime(concrete._creationTime);
      converted.ExpiryTime = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M10_expiryTime(concrete._expiryTime);
      converted.MessagesUsed = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M12_messagesUsed(concrete._messagesUsed);
      converted.BytesUsed = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M9_bytesUsed(concrete._bytesUsed); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IGetCacheEntryOutput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput(AWS.Cryptography.MaterialProviders.GetCacheEntryOutput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.GetCacheEntryOutput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M9_materials(value.Materials), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M12_creationTime(value.CreationTime), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M10_expiryTime(value.ExpiryTime), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M12_messagesUsed(value.MessagesUsed), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M9_bytesUsed(value.BytesUsed));
    }
    internal static AWS.Cryptography.MaterialProviders.GetClientInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GetClientInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IGetClientInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.GetClientInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.GetClientInput)value; AWS.Cryptography.MaterialProviders.GetClientInput converted = new AWS.Cryptography.MaterialProviders.GetClientInput(); converted.Region = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GetClientInput__M6_region(concrete._region); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IGetClientInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GetClientInput(AWS.Cryptography.MaterialProviders.GetClientInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.GetClientInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GetClientInput__M6_region(value.Region));
    }
    internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_GetClientOutput(Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_GetClientOutput__M6_client(value);
    }
    internal static Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_GetClientOutput(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_GetClientOutput__M6_client(value);
    }
    internal static AWS.Cryptography.MaterialProviders.GetEncryptionMaterialsInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IGetEncryptionMaterialsInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.GetEncryptionMaterialsInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.GetEncryptionMaterialsInput)value; AWS.Cryptography.MaterialProviders.GetEncryptionMaterialsInput converted = new AWS.Cryptography.MaterialProviders.GetEncryptionMaterialsInput(); converted.EncryptionContext = (System.Collections.Generic.Dictionary<string, string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M17_encryptionContext(concrete._encryptionContext);
      converted.CommitmentPolicy = (AWS.Cryptography.MaterialProviders.CommitmentPolicy)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M16_commitmentPolicy(concrete._commitmentPolicy);
      if (concrete._algorithmSuiteId.is_Some) converted.AlgorithmSuiteId = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M16_algorithmSuiteId(concrete._algorithmSuiteId);
      if (concrete._maxPlaintextLength.is_Some) converted.MaxPlaintextLength = (long)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M18_maxPlaintextLength(concrete._maxPlaintextLength);
      if (concrete._requiredEncryptionContextKeys.is_Some) converted.RequiredEncryptionContextKeys = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M29_requiredEncryptionContextKeys(concrete._requiredEncryptionContextKeys); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IGetEncryptionMaterialsInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput(AWS.Cryptography.MaterialProviders.GetEncryptionMaterialsInput value)
    {
      AWS.Cryptography.MaterialProviders.AlgorithmSuiteId var_algorithmSuiteId = value.IsSetAlgorithmSuiteId() ? value.AlgorithmSuiteId : (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)null;
      long? var_maxPlaintextLength = value.IsSetMaxPlaintextLength() ? value.MaxPlaintextLength : (long?)null;
      System.Collections.Generic.List<string> var_requiredEncryptionContextKeys = value.IsSetRequiredEncryptionContextKeys() ? value.RequiredEncryptionContextKeys : (System.Collections.Generic.List<string>)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.GetEncryptionMaterialsInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M17_encryptionContext(value.EncryptionContext), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M16_commitmentPolicy(value.CommitmentPolicy), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M16_algorithmSuiteId(var_algorithmSuiteId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M18_maxPlaintextLength(var_maxPlaintextLength), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M29_requiredEncryptionContextKeys(var_requiredEncryptionContextKeys));
    }
    internal static AWS.Cryptography.MaterialProviders.GetEncryptionMaterialsOutput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S28_GetEncryptionMaterialsOutput(Dafny.Aws.Cryptography.MaterialProviders.Types._IGetEncryptionMaterialsOutput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.GetEncryptionMaterialsOutput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.GetEncryptionMaterialsOutput)value; AWS.Cryptography.MaterialProviders.GetEncryptionMaterialsOutput converted = new AWS.Cryptography.MaterialProviders.GetEncryptionMaterialsOutput(); converted.EncryptionMaterials = (AWS.Cryptography.MaterialProviders.EncryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S28_GetEncryptionMaterialsOutput__M19_encryptionMaterials(concrete._encryptionMaterials); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IGetEncryptionMaterialsOutput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S28_GetEncryptionMaterialsOutput(AWS.Cryptography.MaterialProviders.GetEncryptionMaterialsOutput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.GetEncryptionMaterialsOutput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S28_GetEncryptionMaterialsOutput__M19_encryptionMaterials(value.EncryptionMaterials));
    }
    internal static AWS.Cryptography.MaterialProviders.InitializeDecryptionMaterialsInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IInitializeDecryptionMaterialsInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.InitializeDecryptionMaterialsInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.InitializeDecryptionMaterialsInput)value; AWS.Cryptography.MaterialProviders.InitializeDecryptionMaterialsInput converted = new AWS.Cryptography.MaterialProviders.InitializeDecryptionMaterialsInput(); converted.AlgorithmSuiteId = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M16_algorithmSuiteId(concrete._algorithmSuiteId);
      converted.EncryptionContext = (System.Collections.Generic.Dictionary<string, string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M17_encryptionContext(concrete._encryptionContext);
      converted.RequiredEncryptionContextKeys = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M29_requiredEncryptionContextKeys(concrete._requiredEncryptionContextKeys); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IInitializeDecryptionMaterialsInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput(AWS.Cryptography.MaterialProviders.InitializeDecryptionMaterialsInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.InitializeDecryptionMaterialsInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M16_algorithmSuiteId(value.AlgorithmSuiteId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M17_encryptionContext(value.EncryptionContext), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M29_requiredEncryptionContextKeys(value.RequiredEncryptionContextKeys));
    }
    internal static AWS.Cryptography.MaterialProviders.InitializeEncryptionMaterialsInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IInitializeEncryptionMaterialsInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.InitializeEncryptionMaterialsInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.InitializeEncryptionMaterialsInput)value; AWS.Cryptography.MaterialProviders.InitializeEncryptionMaterialsInput converted = new AWS.Cryptography.MaterialProviders.InitializeEncryptionMaterialsInput(); converted.AlgorithmSuiteId = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M16_algorithmSuiteId(concrete._algorithmSuiteId);
      converted.EncryptionContext = (System.Collections.Generic.Dictionary<string, string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M17_encryptionContext(concrete._encryptionContext);
      converted.RequiredEncryptionContextKeys = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M29_requiredEncryptionContextKeys(concrete._requiredEncryptionContextKeys);
      if (concrete._signingKey.is_Some) converted.SigningKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M10_signingKey(concrete._signingKey);
      if (concrete._verificationKey.is_Some) converted.VerificationKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M15_verificationKey(concrete._verificationKey); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IInitializeEncryptionMaterialsInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput(AWS.Cryptography.MaterialProviders.InitializeEncryptionMaterialsInput value)
    {
      System.IO.MemoryStream var_signingKey = value.IsSetSigningKey() ? value.SigningKey : (System.IO.MemoryStream)null;
      System.IO.MemoryStream var_verificationKey = value.IsSetVerificationKey() ? value.VerificationKey : (System.IO.MemoryStream)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.InitializeEncryptionMaterialsInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M16_algorithmSuiteId(value.AlgorithmSuiteId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M17_encryptionContext(value.EncryptionContext), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M29_requiredEncryptionContextKeys(value.RequiredEncryptionContextKeys), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M10_signingKey(var_signingKey), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M15_verificationKey(var_verificationKey));
    }
    internal static AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfo FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_InvalidAlgorithmSuiteInfo(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfo value)
    {
      return new AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfo(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_InvalidAlgorithmSuiteInfo__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfo ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_InvalidAlgorithmSuiteInfo(AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfo value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfo(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_InvalidAlgorithmSuiteInfo__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfoOnDecrypt FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnDecrypt(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfoOnDecrypt value)
    {
      return new AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfoOnDecrypt(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnDecrypt__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfoOnDecrypt ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnDecrypt(AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfoOnDecrypt value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfoOnDecrypt(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnDecrypt__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfoOnEncrypt FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnEncrypt(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfoOnEncrypt value)
    {
      return new AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfoOnEncrypt(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnEncrypt__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfoOnEncrypt ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnEncrypt(AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfoOnEncrypt value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfoOnEncrypt(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnEncrypt__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.InvalidDecryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidDecryptionMaterials(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidDecryptionMaterials value)
    {
      return new AWS.Cryptography.MaterialProviders.InvalidDecryptionMaterials(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidDecryptionMaterials__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidDecryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidDecryptionMaterials(AWS.Cryptography.MaterialProviders.InvalidDecryptionMaterials value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidDecryptionMaterials(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidDecryptionMaterials__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.InvalidDecryptionMaterialsTransition FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidDecryptionMaterialsTransition(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidDecryptionMaterialsTransition value)
    {
      return new AWS.Cryptography.MaterialProviders.InvalidDecryptionMaterialsTransition(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidDecryptionMaterialsTransition__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidDecryptionMaterialsTransition ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidDecryptionMaterialsTransition(AWS.Cryptography.MaterialProviders.InvalidDecryptionMaterialsTransition value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidDecryptionMaterialsTransition(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidDecryptionMaterialsTransition__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.InvalidEncryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidEncryptionMaterials(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidEncryptionMaterials value)
    {
      return new AWS.Cryptography.MaterialProviders.InvalidEncryptionMaterials(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidEncryptionMaterials__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidEncryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidEncryptionMaterials(AWS.Cryptography.MaterialProviders.InvalidEncryptionMaterials value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidEncryptionMaterials(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidEncryptionMaterials__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.InvalidEncryptionMaterialsTransition FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidEncryptionMaterialsTransition(Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidEncryptionMaterialsTransition value)
    {
      return new AWS.Cryptography.MaterialProviders.InvalidEncryptionMaterialsTransition(
      FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidEncryptionMaterialsTransition__M7_message(value._message)
      );
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidEncryptionMaterialsTransition ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidEncryptionMaterialsTransition(AWS.Cryptography.MaterialProviders.InvalidEncryptionMaterialsTransition value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidEncryptionMaterialsTransition(
      ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidEncryptionMaterialsTransition__M7_message(value.Message)
      );
    }
    internal static AWS.Cryptography.MaterialProviders.MaterialProvidersConfig FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_MaterialProvidersConfig(Dafny.Aws.Cryptography.MaterialProviders.Types._IMaterialProvidersConfig value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.MaterialProvidersConfig concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.MaterialProvidersConfig)value; AWS.Cryptography.MaterialProviders.MaterialProvidersConfig converted = new AWS.Cryptography.MaterialProviders.MaterialProvidersConfig(); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IMaterialProvidersConfig ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_MaterialProvidersConfig(AWS.Cryptography.MaterialProviders.MaterialProvidersConfig value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.MaterialProvidersConfig();
    }
    internal static AWS.Cryptography.MaterialProviders.Materials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials(Dafny.Aws.Cryptography.MaterialProviders.Types._IMaterials value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.Materials concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.Materials)value;
      var converted = new AWS.Cryptography.MaterialProviders.Materials(); if (value.is_Encryption)
      {
        converted.Encryption = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M10_Encryption(concrete.dtor_Encryption);
        return converted;
      }
      if (value.is_Decryption)
      {
        converted.Decryption = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M10_Decryption(concrete.dtor_Decryption);
        return converted;
      }
      if (value.is_Hierarchical)
      {
        converted.Hierarchical = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M12_Hierarchical(concrete.dtor_Hierarchical);
        return converted;
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.Materials state");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials(AWS.Cryptography.MaterialProviders.Materials value)
    {
      if (value.IsSetEncryption())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.Materials.create_Encryption(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M10_Encryption(value.Encryption));
      }
      if (value.IsSetDecryption())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.Materials.create_Decryption(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M10_Decryption(value.Decryption));
      }
      if (value.IsSetHierarchical())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.Materials.create_Hierarchical(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M12_Hierarchical(value.Hierarchical));
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.Materials state");
    }
    internal static AWS.Cryptography.MaterialProviders.OnDecryptInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IOnDecryptInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.OnDecryptInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.OnDecryptInput)value; AWS.Cryptography.MaterialProviders.OnDecryptInput converted = new AWS.Cryptography.MaterialProviders.OnDecryptInput(); converted.Materials = (AWS.Cryptography.MaterialProviders.DecryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput__M9_materials(concrete._materials);
      converted.EncryptedDataKeys = (System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput__M17_encryptedDataKeys(concrete._encryptedDataKeys); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IOnDecryptInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput(AWS.Cryptography.MaterialProviders.OnDecryptInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.OnDecryptInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput__M9_materials(value.Materials), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput__M17_encryptedDataKeys(value.EncryptedDataKeys));
    }
    internal static AWS.Cryptography.MaterialProviders.OnDecryptOutput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnDecryptOutput(Dafny.Aws.Cryptography.MaterialProviders.Types._IOnDecryptOutput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.OnDecryptOutput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.OnDecryptOutput)value; AWS.Cryptography.MaterialProviders.OnDecryptOutput converted = new AWS.Cryptography.MaterialProviders.OnDecryptOutput(); converted.Materials = (AWS.Cryptography.MaterialProviders.DecryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnDecryptOutput__M9_materials(concrete._materials); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IOnDecryptOutput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnDecryptOutput(AWS.Cryptography.MaterialProviders.OnDecryptOutput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.OnDecryptOutput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnDecryptOutput__M9_materials(value.Materials));
    }
    internal static AWS.Cryptography.MaterialProviders.OnEncryptInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnEncryptInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IOnEncryptInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.OnEncryptInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.OnEncryptInput)value; AWS.Cryptography.MaterialProviders.OnEncryptInput converted = new AWS.Cryptography.MaterialProviders.OnEncryptInput(); converted.Materials = (AWS.Cryptography.MaterialProviders.EncryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnEncryptInput__M9_materials(concrete._materials); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IOnEncryptInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnEncryptInput(AWS.Cryptography.MaterialProviders.OnEncryptInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.OnEncryptInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnEncryptInput__M9_materials(value.Materials));
    }
    internal static AWS.Cryptography.MaterialProviders.OnEncryptOutput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnEncryptOutput(Dafny.Aws.Cryptography.MaterialProviders.Types._IOnEncryptOutput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.OnEncryptOutput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.OnEncryptOutput)value; AWS.Cryptography.MaterialProviders.OnEncryptOutput converted = new AWS.Cryptography.MaterialProviders.OnEncryptOutput(); converted.Materials = (AWS.Cryptography.MaterialProviders.EncryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnEncryptOutput__M9_materials(concrete._materials); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IOnEncryptOutput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnEncryptOutput(AWS.Cryptography.MaterialProviders.OnEncryptOutput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.OnEncryptOutput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnEncryptOutput__M9_materials(value.Materials));
    }
    internal static AWS.Cryptography.MaterialProviders.PaddingScheme FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_PaddingScheme(Dafny.Aws.Cryptography.MaterialProviders.Types._IPaddingScheme value)
    {
      if (value.is_PKCS1) return AWS.Cryptography.MaterialProviders.PaddingScheme.PKCS1;
      if (value.is_OAEP__SHA1__MGF1) return AWS.Cryptography.MaterialProviders.PaddingScheme.OAEP_SHA1_MGF1;
      if (value.is_OAEP__SHA256__MGF1) return AWS.Cryptography.MaterialProviders.PaddingScheme.OAEP_SHA256_MGF1;
      if (value.is_OAEP__SHA384__MGF1) return AWS.Cryptography.MaterialProviders.PaddingScheme.OAEP_SHA384_MGF1;
      if (value.is_OAEP__SHA512__MGF1) return AWS.Cryptography.MaterialProviders.PaddingScheme.OAEP_SHA512_MGF1;
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.PaddingScheme value");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IPaddingScheme ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_PaddingScheme(AWS.Cryptography.MaterialProviders.PaddingScheme value)
    {
      if (AWS.Cryptography.MaterialProviders.PaddingScheme.PKCS1.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.PaddingScheme.create_PKCS1();
      if (AWS.Cryptography.MaterialProviders.PaddingScheme.OAEP_SHA1_MGF1.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.PaddingScheme.create_OAEP__SHA1__MGF1();
      if (AWS.Cryptography.MaterialProviders.PaddingScheme.OAEP_SHA256_MGF1.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.PaddingScheme.create_OAEP__SHA256__MGF1();
      if (AWS.Cryptography.MaterialProviders.PaddingScheme.OAEP_SHA384_MGF1.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.PaddingScheme.create_OAEP__SHA384__MGF1();
      if (AWS.Cryptography.MaterialProviders.PaddingScheme.OAEP_SHA512_MGF1.Equals(value)) return Dafny.Aws.Cryptography.MaterialProviders.Types.PaddingScheme.create_OAEP__SHA512__MGF1();
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.PaddingScheme value");
    }
    internal static AWS.Cryptography.MaterialProviders.PutCacheEntryInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IPutCacheEntryInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.PutCacheEntryInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.PutCacheEntryInput)value; AWS.Cryptography.MaterialProviders.PutCacheEntryInput converted = new AWS.Cryptography.MaterialProviders.PutCacheEntryInput(); converted.Identifier = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M10_identifier(concrete._identifier);
      converted.Materials = (AWS.Cryptography.MaterialProviders.Materials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M9_materials(concrete._materials);
      converted.CreationTime = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M12_creationTime(concrete._creationTime);
      converted.ExpiryTime = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M10_expiryTime(concrete._expiryTime);
      if (concrete._messagesUsed.is_Some) converted.MessagesUsed = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M12_messagesUsed(concrete._messagesUsed);
      if (concrete._bytesUsed.is_Some) converted.BytesUsed = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M9_bytesUsed(concrete._bytesUsed); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IPutCacheEntryInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput(AWS.Cryptography.MaterialProviders.PutCacheEntryInput value)
    {
      int? var_messagesUsed = value.IsSetMessagesUsed() ? value.MessagesUsed : (int?)null;
      int? var_bytesUsed = value.IsSetBytesUsed() ? value.BytesUsed : (int?)null;
      return new Dafny.Aws.Cryptography.MaterialProviders.Types.PutCacheEntryInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M10_identifier(value.Identifier), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M9_materials(value.Materials), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M12_creationTime(value.CreationTime), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M10_expiryTime(value.ExpiryTime), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M12_messagesUsed(var_messagesUsed), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M9_bytesUsed(var_bytesUsed));
    }
    internal static AWS.Cryptography.MaterialProviders.SignatureAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm(Dafny.Aws.Cryptography.MaterialProviders.Types._ISignatureAlgorithm value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.SignatureAlgorithm concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.SignatureAlgorithm)value;
      var converted = new AWS.Cryptography.MaterialProviders.SignatureAlgorithm(); if (value.is_ECDSA)
      {
        converted.ECDSA = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm__M5_ECDSA(concrete.dtor_ECDSA);
        return converted;
      }
      if (value.is_None)
      {
        converted.None = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm__M4_None(concrete.dtor_None);
        return converted;
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.SignatureAlgorithm state");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ISignatureAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm(AWS.Cryptography.MaterialProviders.SignatureAlgorithm value)
    {
      if (value.IsSetECDSA())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.SignatureAlgorithm.create_ECDSA(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm__M5_ECDSA(value.ECDSA));
      }
      if (value.IsSetNone())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.SignatureAlgorithm.create_None(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm__M4_None(value.None));
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.SignatureAlgorithm state");
    }
    internal static AWS.Cryptography.MaterialProviders.SymmetricSignatureAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm(Dafny.Aws.Cryptography.MaterialProviders.Types._ISymmetricSignatureAlgorithm value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.SymmetricSignatureAlgorithm concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.SymmetricSignatureAlgorithm)value;
      var converted = new AWS.Cryptography.MaterialProviders.SymmetricSignatureAlgorithm(); if (value.is_HMAC)
      {
        converted.HMAC = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm__M4_HMAC(concrete.dtor_HMAC);
        return converted;
      }
      if (value.is_None)
      {
        converted.None = FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm__M4_None(concrete.dtor_None);
        return converted;
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.SymmetricSignatureAlgorithm state");
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ISymmetricSignatureAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm(AWS.Cryptography.MaterialProviders.SymmetricSignatureAlgorithm value)
    {
      if (value.IsSetHMAC())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.SymmetricSignatureAlgorithm.create_HMAC(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm__M4_HMAC(value.HMAC));
      }
      if (value.IsSetNone())
      {
        return Dafny.Aws.Cryptography.MaterialProviders.Types.SymmetricSignatureAlgorithm.create_None(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm__M4_None(value.None));
      }
      throw new System.ArgumentException("Invalid AWS.Cryptography.MaterialProviders.SymmetricSignatureAlgorithm state");
    }
    internal static AWS.Cryptography.MaterialProviders.UpdaterUsageMetadataInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IUpdaterUsageMetadataInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.UpdaterUsageMetadataInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.UpdaterUsageMetadataInput)value; AWS.Cryptography.MaterialProviders.UpdaterUsageMetadataInput converted = new AWS.Cryptography.MaterialProviders.UpdaterUsageMetadataInput(); converted.Identifier = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput__M10_identifier(concrete._identifier);
      converted.BytesUsed = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput__M9_bytesUsed(concrete._bytesUsed); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IUpdaterUsageMetadataInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput(AWS.Cryptography.MaterialProviders.UpdaterUsageMetadataInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.UpdaterUsageMetadataInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput__M10_identifier(value.Identifier), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput__M9_bytesUsed(value.BytesUsed));
    }
    internal static AWS.Cryptography.MaterialProviders.ValidateCommitmentPolicyOnDecryptInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IValidateCommitmentPolicyOnDecryptInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.ValidateCommitmentPolicyOnDecryptInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.ValidateCommitmentPolicyOnDecryptInput)value; AWS.Cryptography.MaterialProviders.ValidateCommitmentPolicyOnDecryptInput converted = new AWS.Cryptography.MaterialProviders.ValidateCommitmentPolicyOnDecryptInput(); converted.Algorithm = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput__M9_algorithm(concrete._algorithm);
      converted.CommitmentPolicy = (AWS.Cryptography.MaterialProviders.CommitmentPolicy)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput__M16_commitmentPolicy(concrete._commitmentPolicy); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IValidateCommitmentPolicyOnDecryptInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput(AWS.Cryptography.MaterialProviders.ValidateCommitmentPolicyOnDecryptInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.ValidateCommitmentPolicyOnDecryptInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput__M9_algorithm(value.Algorithm), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput__M16_commitmentPolicy(value.CommitmentPolicy));
    }
    internal static AWS.Cryptography.MaterialProviders.ValidateCommitmentPolicyOnEncryptInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IValidateCommitmentPolicyOnEncryptInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.ValidateCommitmentPolicyOnEncryptInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.ValidateCommitmentPolicyOnEncryptInput)value; AWS.Cryptography.MaterialProviders.ValidateCommitmentPolicyOnEncryptInput converted = new AWS.Cryptography.MaterialProviders.ValidateCommitmentPolicyOnEncryptInput(); converted.Algorithm = (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput__M9_algorithm(concrete._algorithm);
      converted.CommitmentPolicy = (AWS.Cryptography.MaterialProviders.CommitmentPolicy)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput__M16_commitmentPolicy(concrete._commitmentPolicy); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IValidateCommitmentPolicyOnEncryptInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput(AWS.Cryptography.MaterialProviders.ValidateCommitmentPolicyOnEncryptInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.ValidateCommitmentPolicyOnEncryptInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput__M9_algorithm(value.Algorithm), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput__M16_commitmentPolicy(value.CommitmentPolicy));
    }
    internal static AWS.Cryptography.MaterialProviders.ValidDecryptionMaterialsTransitionInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IValidDecryptionMaterialsTransitionInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.ValidDecryptionMaterialsTransitionInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.ValidDecryptionMaterialsTransitionInput)value; AWS.Cryptography.MaterialProviders.ValidDecryptionMaterialsTransitionInput converted = new AWS.Cryptography.MaterialProviders.ValidDecryptionMaterialsTransitionInput(); converted.Start = (AWS.Cryptography.MaterialProviders.DecryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput__M5_start(concrete._start);
      converted.Stop = (AWS.Cryptography.MaterialProviders.DecryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput__M4_stop(concrete._stop); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IValidDecryptionMaterialsTransitionInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput(AWS.Cryptography.MaterialProviders.ValidDecryptionMaterialsTransitionInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.ValidDecryptionMaterialsTransitionInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput__M5_start(value.Start), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput__M4_stop(value.Stop));
    }
    internal static AWS.Cryptography.MaterialProviders.ValidEncryptionMaterialsTransitionInput FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput(Dafny.Aws.Cryptography.MaterialProviders.Types._IValidEncryptionMaterialsTransitionInput value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.ValidEncryptionMaterialsTransitionInput concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.ValidEncryptionMaterialsTransitionInput)value; AWS.Cryptography.MaterialProviders.ValidEncryptionMaterialsTransitionInput converted = new AWS.Cryptography.MaterialProviders.ValidEncryptionMaterialsTransitionInput(); converted.Start = (AWS.Cryptography.MaterialProviders.EncryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput__M5_start(concrete._start);
      converted.Stop = (AWS.Cryptography.MaterialProviders.EncryptionMaterials)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput__M4_stop(concrete._stop); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IValidEncryptionMaterialsTransitionInput ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput(AWS.Cryptography.MaterialProviders.ValidEncryptionMaterialsTransitionInput value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.ValidEncryptionMaterialsTransitionInput(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput__M5_start(value.Start), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput__M4_stop(value.Stop));
    }
    internal static AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId__M4_ESDK(Dafny.Aws.Cryptography.MaterialProviders.Types._IESDKAlgorithmSuiteId value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_ESDKAlgorithmSuiteId(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IESDKAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId__M4_ESDK(AWS.Cryptography.MaterialProviders.ESDKAlgorithmSuiteId value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_ESDKAlgorithmSuiteId(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId__M3_DBE(Dafny.Aws.Cryptography.MaterialProviders.Types._IDBEAlgorithmSuiteId value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DBEAlgorithmSuiteId(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDBEAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId__M3_DBE(AWS.Cryptography.MaterialProviders.DBEAlgorithmSuiteId value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DBEAlgorithmSuiteId(value);
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M2_id(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M2_id(AWS.Cryptography.MaterialProviders.AlgorithmSuiteId value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M8_binaryId(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M8_binaryId(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M14_messageVersion(int value)
    {
      return FromDafny_N6_smithy__N3_api__S7_Integer(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M14_messageVersion(int value)
    {
      return ToDafny_N6_smithy__N3_api__S7_Integer(value);
    }
    internal static AWS.Cryptography.MaterialProviders.Encrypt FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M7_encrypt(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncrypt value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncrypt ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M7_encrypt(AWS.Cryptography.MaterialProviders.Encrypt value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DerivationAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M3_kdf(Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M3_kdf(AWS.Cryptography.MaterialProviders.DerivationAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DerivationAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M10_commitment(Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M10_commitment(AWS.Cryptography.MaterialProviders.DerivationAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(value);
    }
    internal static AWS.Cryptography.MaterialProviders.SignatureAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M9_signature(Dafny.Aws.Cryptography.MaterialProviders.Types._ISignatureAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ISignatureAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M9_signature(AWS.Cryptography.MaterialProviders.SignatureAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm(value);
    }
    internal static AWS.Cryptography.MaterialProviders.SymmetricSignatureAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M18_symmetricSignature(Dafny.Aws.Cryptography.MaterialProviders.Types._ISymmetricSignatureAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ISymmetricSignatureAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M18_symmetricSignature(AWS.Cryptography.MaterialProviders.SymmetricSignatureAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm(value);
    }
    internal static AWS.Cryptography.MaterialProviders.EdkWrappingAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M11_edkWrapping(Dafny.Aws.Cryptography.MaterialProviders.Types._IEdkWrappingAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEdkWrappingAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo__M11_edkWrapping(AWS.Cryptography.MaterialProviders.EdkWrappingAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S42_AwsCryptographicMaterialProvidersException__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S42_AwsCryptographicMaterialProvidersException__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy__M4_ESDK(Dafny.Aws.Cryptography.MaterialProviders.Types._IESDKCommitmentPolicy value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_ESDKCommitmentPolicy(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IESDKCommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy__M4_ESDK(AWS.Cryptography.MaterialProviders.ESDKCommitmentPolicy value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_ESDKCommitmentPolicy(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DBECommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy__M3_DBE(Dafny.Aws.Cryptography.MaterialProviders.Types._IDBECommitmentPolicy value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DBECommitmentPolicy(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDBECommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy__M3_DBE(AWS.Cryptography.MaterialProviders.DBECommitmentPolicy value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DBECommitmentPolicy(value);
    }
    internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M9_kmsClient(Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M9_kmsClient(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DiscoveryFilter FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M15_discoveryFilter(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.DiscoveryFilter)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M15_discoveryFilter(AWS.Cryptography.MaterialProviders.DiscoveryFilter value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter((AWS.Cryptography.MaterialProviders.DiscoveryFilter)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateAwsKmsDiscoveryKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M7_regions(Dafny.ISequence<Dafny.ISequence<char>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList(value);
    }
    internal static Dafny.ISequence<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M7_regions(System.Collections.Generic.List<string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DiscoveryFilter FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M15_discoveryFilter(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.DiscoveryFilter)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M15_discoveryFilter(AWS.Cryptography.MaterialProviders.DiscoveryFilter value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter((AWS.Cryptography.MaterialProviders.DiscoveryFilter)value));
    }
    internal static AWS.Cryptography.MaterialProviders.IClientSupplier FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M14_clientSupplier(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.IClientSupplier)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M14_clientSupplier(AWS.Cryptography.MaterialProviders.IClientSupplier value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference((AWS.Cryptography.MaterialProviders.IClientSupplier)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateAwsKmsDiscoveryMultiKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M11_branchKeyId(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M11_branchKeyId(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M8_kmsKeyId(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M8_kmsKeyId(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M9_kmsClient(Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M9_kmsClient(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static Amazon.DynamoDBv2.IAmazonDynamoDB FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M9_ddbClient(Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDB__20120810Client value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference(value);
    }
    internal static Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDB__20120810Client ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M9_ddbClient(Amazon.DynamoDBv2.IAmazonDynamoDB value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M17_branchKeyStoreArn(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_DdbTableArn(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M17_branchKeyStoreArn(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_DdbTableArn(value);
    }
    internal static long FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M10_ttlSeconds(long value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Long(value);
    }
    internal static long ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M10_ttlSeconds(long value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Long(value);
    }
    internal static int? FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M12_maxCacheSize(Wrappers_Compile._IOption<int> value)
    {
      return value.is_None ? (int?)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_PositiveInteger(value.Extract());
    }
    internal static Wrappers_Compile._IOption<int> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M12_maxCacheSize(int? value)
    {
      return value == null ? Wrappers_Compile.Option<int>.create_None() : Wrappers_Compile.Option<int>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_PositiveInteger((int)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsHierarchicalKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M8_kmsKeyId(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M8_kmsKeyId(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M9_kmsClient(Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M9_kmsClient(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateAwsKmsKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M9_kmsClient(Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M9_kmsClient(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DiscoveryFilter FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M15_discoveryFilter(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.DiscoveryFilter)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M15_discoveryFilter(AWS.Cryptography.MaterialProviders.DiscoveryFilter value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter((AWS.Cryptography.MaterialProviders.DiscoveryFilter)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M6_region(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Region(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CreateAwsKmsMrkDiscoveryKeyringInput__M6_region(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Region(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M7_regions(Dafny.ISequence<Dafny.ISequence<char>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList(value);
    }
    internal static Dafny.ISequence<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M7_regions(System.Collections.Generic.List<string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DiscoveryFilter FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M15_discoveryFilter(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.DiscoveryFilter)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M15_discoveryFilter(AWS.Cryptography.MaterialProviders.DiscoveryFilter value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter((AWS.Cryptography.MaterialProviders.DiscoveryFilter)value));
    }
    internal static AWS.Cryptography.MaterialProviders.IClientSupplier FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M14_clientSupplier(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.IClientSupplier)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M14_clientSupplier(AWS.Cryptography.MaterialProviders.IClientSupplier value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference((AWS.Cryptography.MaterialProviders.IClientSupplier)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateAwsKmsMrkDiscoveryMultiKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M8_kmsKeyId(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M8_kmsKeyId(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M9_kmsClient(Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M9_kmsClient(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsMrkKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M9_generator(Wrappers_Compile._IOption<Dafny.ISequence<char>> value)
    {
      return value.is_None ? (string)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M9_generator(string value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<char>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<char>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId((string)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M9_kmsKeyIds(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M9_kmsKeyIds(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList((System.Collections.Generic.List<string>)value));
    }
    internal static AWS.Cryptography.MaterialProviders.IClientSupplier FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M14_clientSupplier(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.IClientSupplier)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M14_clientSupplier(AWS.Cryptography.MaterialProviders.IClientSupplier value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference((AWS.Cryptography.MaterialProviders.IClientSupplier)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S32_CreateAwsKmsMrkMultiKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M9_generator(Wrappers_Compile._IOption<Dafny.ISequence<char>> value)
    {
      return value.is_None ? (string)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M9_generator(string value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<char>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<char>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId((string)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M9_kmsKeyIds(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M9_kmsKeyIds(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList((System.Collections.Generic.List<string>)value));
    }
    internal static AWS.Cryptography.MaterialProviders.IClientSupplier FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M14_clientSupplier(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.IClientSupplier)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M14_clientSupplier(AWS.Cryptography.MaterialProviders.IClientSupplier value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference((AWS.Cryptography.MaterialProviders.IClientSupplier)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S29_CreateAwsKmsMultiKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M9_publicKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M9_publicKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M8_kmsKeyId(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M8_kmsKeyId(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Amazon.KeyManagementService.EncryptionAlgorithmSpec FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M19_encryptionAlgorithm(Dafny.Com.Amazonaws.Kms.Types._IEncryptionAlgorithmSpec value)
    {
      return FromDafny_N3_com__N9_amazonaws__N3_kms__S23_EncryptionAlgorithmSpec(value);
    }
    internal static Dafny.Com.Amazonaws.Kms.Types._IEncryptionAlgorithmSpec ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M19_encryptionAlgorithm(Amazon.KeyManagementService.EncryptionAlgorithmSpec value)
    {
      return ToDafny_N3_com__N9_amazonaws__N3_kms__S23_EncryptionAlgorithmSpec(value);
    }
    internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M9_kmsClient(Wrappers_Compile._IOption<Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient> value)
    {
      return value.is_None ? (Amazon.KeyManagementService.IAmazonKeyManagementService)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M9_kmsClient(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient>.create_None() : Wrappers_Compile.Option<Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference((Amazon.KeyManagementService.IAmazonKeyManagementService)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M11_grantTokens(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<char>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_CreateAwsKmsRsaKeyringInput__M11_grantTokens(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<char>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList((System.Collections.Generic.List<string>)value));
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput__M13_entryCapacity(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput__M13_entryCapacity(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int? FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput__M20_entryPruningTailSize(Wrappers_Compile._IOption<int> value)
    {
      return value.is_None ? (int?)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value.Extract());
    }
    internal static Wrappers_Compile._IOption<int> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CreateCryptographicMaterialsCacheInput__M20_entryPruningTailSize(int? value)
    {
      return value == null ? Wrappers_Compile.Option<int>.create_None() : Wrappers_Compile.Option<int>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong((int)value));
    }
    internal static AWS.Cryptography.MaterialProviders.ICryptographicMaterialsCache FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_CreateCryptographicMaterialsCacheOutput__M14_materialsCache(Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsCache value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CryptographicMaterialsCacheReference(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsCache ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_CreateCryptographicMaterialsCacheOutput__M14_materialsCache(AWS.Cryptography.MaterialProviders.ICryptographicMaterialsCache value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CryptographicMaterialsCacheReference(value);
    }
    internal static AWS.Cryptography.MaterialProviders.ICryptographicMaterialsManager FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateCryptographicMaterialsManagerOutput__M16_materialsManager(Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsManager value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CryptographicMaterialsManagerReference(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsManager ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S41_CreateCryptographicMaterialsManagerOutput__M16_materialsManager(AWS.Cryptography.MaterialProviders.ICryptographicMaterialsManager value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CryptographicMaterialsManagerReference(value);
    }
    internal static AWS.Cryptography.MaterialProviders.IClientSupplier FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateDefaultClientSupplierOutput__M6_client(Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S33_CreateDefaultClientSupplierOutput__M6_client(AWS.Cryptography.MaterialProviders.IClientSupplier value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(value);
    }
    internal static AWS.Cryptography.MaterialProviders.IKeyring FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S47_CreateDefaultCryptographicMaterialsManagerInput__M7_keyring(Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S47_CreateDefaultCryptographicMaterialsManagerInput__M7_keyring(AWS.Cryptography.MaterialProviders.IKeyring value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value);
    }
    internal static AWS.Cryptography.MaterialProviders.IKeyring FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_CreateKeyringOutput__M7_keyring(Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_CreateKeyringOutput__M7_keyring(AWS.Cryptography.MaterialProviders.IKeyring value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value);
    }
    internal static AWS.Cryptography.MaterialProviders.IKeyring FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput__M9_generator(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.IKeyring)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput__M9_generator(AWS.Cryptography.MaterialProviders.IKeyring value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference((AWS.Cryptography.MaterialProviders.IKeyring)value));
    }
    internal static System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.IKeyring> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput__M13_childKeyrings(Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_KeyringList(value);
    }
    internal static Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_CreateMultiKeyringInput__M13_childKeyrings(System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.IKeyring> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_KeyringList(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M12_keyNamespace(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M12_keyNamespace(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M7_keyName(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M7_keyName(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M11_wrappingKey(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M11_wrappingKey(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static AWS.Cryptography.MaterialProviders.AesWrappingAlg FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M11_wrappingAlg(Dafny.Aws.Cryptography.MaterialProviders.Types._IAesWrappingAlg value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_AesWrappingAlg(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAesWrappingAlg ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawAesKeyringInput__M11_wrappingAlg(AWS.Cryptography.MaterialProviders.AesWrappingAlg value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_AesWrappingAlg(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M12_keyNamespace(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M12_keyNamespace(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M7_keyName(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M7_keyName(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static AWS.Cryptography.MaterialProviders.PaddingScheme FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M13_paddingScheme(Dafny.Aws.Cryptography.MaterialProviders.Types._IPaddingScheme value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_PaddingScheme(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IPaddingScheme ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M13_paddingScheme(AWS.Cryptography.MaterialProviders.PaddingScheme value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_PaddingScheme(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M9_publicKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N6_smithy__N3_api__S4_Blob(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M9_publicKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N6_smithy__N3_api__S4_Blob((System.IO.MemoryStream)value));
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M10_privateKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N6_smithy__N3_api__S4_Blob(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S24_CreateRawRsaKeyringInput__M10_privateKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N6_smithy__N3_api__S4_Blob((System.IO.MemoryStream)value));
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M14_algorithmSuite(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteInfo value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteInfo ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M14_algorithmSuite(AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo(value);
    }
    internal static System.Collections.Generic.Dictionary<string, string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M17_encryptionContext(Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M17_encryptionContext(System.Collections.Generic.Dictionary<string, string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M29_requiredEncryptionContextKeys(Dafny.ISequence<Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value);
    }
    internal static Dafny.ISequence<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M29_requiredEncryptionContextKeys(System.Collections.Generic.List<string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M16_plaintextDataKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M16_plaintextDataKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream)value));
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M15_verificationKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M15_verificationKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream)value));
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M19_symmetricSigningKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials__M19_symmetricSigningKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream)value));
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M16_algorithmSuiteId(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M16_algorithmSuiteId(AWS.Cryptography.MaterialProviders.AlgorithmSuiteId value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static AWS.Cryptography.MaterialProviders.CommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M16_commitmentPolicy(Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M16_commitmentPolicy(AWS.Cryptography.MaterialProviders.CommitmentPolicy value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(value);
    }
    internal static System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M17_encryptedDataKeys(Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList(value);
    }
    internal static Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M17_encryptedDataKeys(System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList(value);
    }
    internal static System.Collections.Generic.Dictionary<string, string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M17_encryptionContext(Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M17_encryptionContext(System.Collections.Generic.Dictionary<string, string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static System.Collections.Generic.Dictionary<string, string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M27_reproducedEncryptionContext(Wrappers_Compile._IOption<Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>>> value)
    {
      return value.is_None ? (System.Collections.Generic.Dictionary<string, string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DecryptMaterialsInput__M27_reproducedEncryptionContext(System.Collections.Generic.Dictionary<string, string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>>>.create_None() : Wrappers_Compile.Option<Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext((System.Collections.Generic.Dictionary<string, string>)value));
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S22_DecryptMaterialsOutput__M19_decryptionMaterials(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S22_DecryptMaterialsOutput__M19_decryptionMaterials(AWS.Cryptography.MaterialProviders.DecryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DeleteCacheEntryInput__M10_identifier(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_DeleteCacheEntryInput__M10_identifier(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static AWS.Cryptography.MaterialProviders.HKDF FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M4_HKDF(Dafny.Aws.Cryptography.MaterialProviders.Types._IHKDF value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IHKDF ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M4_HKDF(AWS.Cryptography.MaterialProviders.HKDF value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF(value);
    }
    internal static AWS.Cryptography.MaterialProviders.IDENTITY FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M8_IDENTITY(Dafny.Aws.Cryptography.MaterialProviders.Types._IIDENTITY value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_IDENTITY(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IIDENTITY ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M8_IDENTITY(AWS.Cryptography.MaterialProviders.IDENTITY value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_IDENTITY(value);
    }
    internal static AWS.Cryptography.MaterialProviders.None FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M4_None(Dafny.Aws.Cryptography.MaterialProviders.Types._INone value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_None(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._INone ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm__M4_None(AWS.Cryptography.MaterialProviders.None value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_None(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DIRECT_KEY_WRAPPING FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm__M19_DIRECT_KEY_WRAPPING(Dafny.Aws.Cryptography.MaterialProviders.Types._IDIRECT__KEY__WRAPPING value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DIRECT_KEY_WRAPPING(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDIRECT__KEY__WRAPPING ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm__M19_DIRECT_KEY_WRAPPING(AWS.Cryptography.MaterialProviders.DIRECT_KEY_WRAPPING value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DIRECT_KEY_WRAPPING(value);
    }
    internal static AWS.Cryptography.MaterialProviders.IntermediateKeyWrapping FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm__M23_IntermediateKeyWrapping(Dafny.Aws.Cryptography.MaterialProviders.Types._IIntermediateKeyWrapping value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IIntermediateKeyWrapping ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EdkWrappingAlgorithm__M23_IntermediateKeyWrapping(AWS.Cryptography.MaterialProviders.IntermediateKeyWrapping value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping(value);
    }
    internal static AWS.Cryptography.Primitives.AES_GCM FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt__M7_AES_GCM(Dafny.Aws.Cryptography.Primitives.Types._IAES__GCM value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM(value);
    }
    internal static Dafny.Aws.Cryptography.Primitives.Types._IAES__GCM ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt__M7_AES_GCM(AWS.Cryptography.Primitives.AES_GCM value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM(value);
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M14_algorithmSuite(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteInfo value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteInfo ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M14_algorithmSuite(AWS.Cryptography.MaterialProviders.AlgorithmSuiteInfo value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_AlgorithmSuiteInfo(value);
    }
    internal static System.Collections.Generic.Dictionary<string, string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M17_encryptionContext(Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M17_encryptionContext(System.Collections.Generic.Dictionary<string, string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M17_encryptedDataKeys(Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList(value);
    }
    internal static Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M17_encryptedDataKeys(System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M29_requiredEncryptionContextKeys(Dafny.ISequence<Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value);
    }
    internal static Dafny.ISequence<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M29_requiredEncryptionContextKeys(System.Collections.Generic.List<string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M16_plaintextDataKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M16_plaintextDataKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream)value));
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M10_signingKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M10_signingKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream)value));
    }
    internal static System.Collections.Generic.List<System.IO.MemoryStream> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M20_symmetricSigningKeys(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<byte>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<System.IO.MemoryStream>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_SymmetricSigningKeyList(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<byte>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials__M20_symmetricSigningKeys(System.Collections.Generic.List<System.IO.MemoryStream> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<byte>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<byte>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_SymmetricSigningKeyList((System.Collections.Generic.List<System.IO.MemoryStream>)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_EntryAlreadyExists__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_EntryAlreadyExists__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EntryDoesNotExist__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EntryDoesNotExist__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_GetAlgorithmSuiteInfoInput__M8_binaryId(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_GetAlgorithmSuiteInfoInput__M8_binaryId(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput__M10_identifier(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput__M10_identifier(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static long? FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput__M9_bytesUsed(Wrappers_Compile._IOption<long> value)
    {
      return value.is_None ? (long?)null : FromDafny_N6_smithy__N3_api__S4_Long(value.Extract());
    }
    internal static Wrappers_Compile._IOption<long> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_GetCacheEntryInput__M9_bytesUsed(long? value)
    {
      return value == null ? Wrappers_Compile.Option<long>.create_None() : Wrappers_Compile.Option<long>.create_Some(ToDafny_N6_smithy__N3_api__S4_Long((long)value));
    }
    internal static AWS.Cryptography.MaterialProviders.Materials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M9_materials(Dafny.Aws.Cryptography.MaterialProviders.Types._IMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M9_materials(AWS.Cryptography.MaterialProviders.Materials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M12_creationTime(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M12_creationTime(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M10_expiryTime(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M10_expiryTime(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M12_messagesUsed(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M12_messagesUsed(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M9_bytesUsed(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_GetCacheEntryOutput__M9_bytesUsed(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GetClientInput__M6_region(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Region(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GetClientInput__M6_region(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Region(value);
    }
    internal static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_GetClientOutput__M6_client(Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_GetClientOutput__M6_client(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(value);
    }
    internal static System.Collections.Generic.Dictionary<string, string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M17_encryptionContext(Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M17_encryptionContext(System.Collections.Generic.Dictionary<string, string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static AWS.Cryptography.MaterialProviders.CommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M16_commitmentPolicy(Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M16_commitmentPolicy(AWS.Cryptography.MaterialProviders.CommitmentPolicy value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(value);
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M16_algorithmSuiteId(Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId> value)
    {
      return value.is_None ? (AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M16_algorithmSuiteId(AWS.Cryptography.MaterialProviders.AlgorithmSuiteId value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId>.create_None() : Wrappers_Compile.Option<Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId((AWS.Cryptography.MaterialProviders.AlgorithmSuiteId)value));
    }
    internal static long? FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M18_maxPlaintextLength(Wrappers_Compile._IOption<long> value)
    {
      return value.is_None ? (long?)null : FromDafny_N6_smithy__N3_api__S4_Long(value.Extract());
    }
    internal static Wrappers_Compile._IOption<long> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M18_maxPlaintextLength(long? value)
    {
      return value == null ? Wrappers_Compile.Option<long>.create_None() : Wrappers_Compile.Option<long>.create_Some(ToDafny_N6_smithy__N3_api__S4_Long((long)value));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M29_requiredEncryptionContextKeys(Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<byte>>> value)
    {
      return value.is_None ? (System.Collections.Generic.List<string>)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<Dafny.ISequence<byte>>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_GetEncryptionMaterialsInput__M29_requiredEncryptionContextKeys(System.Collections.Generic.List<string> value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<byte>>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<Dafny.ISequence<byte>>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys((System.Collections.Generic.List<string>)value));
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S28_GetEncryptionMaterialsOutput__M19_encryptionMaterials(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S28_GetEncryptionMaterialsOutput__M19_encryptionMaterials(AWS.Cryptography.MaterialProviders.EncryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M16_algorithmSuiteId(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M16_algorithmSuiteId(AWS.Cryptography.MaterialProviders.AlgorithmSuiteId value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static System.Collections.Generic.Dictionary<string, string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M17_encryptionContext(Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M17_encryptionContext(System.Collections.Generic.Dictionary<string, string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M29_requiredEncryptionContextKeys(Dafny.ISequence<Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value);
    }
    internal static Dafny.ISequence<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeDecryptionMaterialsInput__M29_requiredEncryptionContextKeys(System.Collections.Generic.List<string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value);
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M16_algorithmSuiteId(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M16_algorithmSuiteId(AWS.Cryptography.MaterialProviders.AlgorithmSuiteId value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static System.Collections.Generic.Dictionary<string, string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M17_encryptionContext(Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M17_encryptionContext(System.Collections.Generic.Dictionary<string, string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M29_requiredEncryptionContextKeys(Dafny.ISequence<Dafny.ISequence<byte>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value);
    }
    internal static Dafny.ISequence<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M29_requiredEncryptionContextKeys(System.Collections.Generic.List<string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M10_signingKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M10_signingKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream)value));
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M15_verificationKey(Wrappers_Compile._IOption<Dafny.ISequence<byte>> value)
    {
      return value.is_None ? (System.IO.MemoryStream)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value.Extract());
    }
    internal static Wrappers_Compile._IOption<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InitializeEncryptionMaterialsInput__M15_verificationKey(System.IO.MemoryStream value)
    {
      return value == null ? Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_None() : Wrappers_Compile.Option<Dafny.ISequence<byte>>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret((System.IO.MemoryStream)value));
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_InvalidAlgorithmSuiteInfo__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_InvalidAlgorithmSuiteInfo__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnDecrypt__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnDecrypt__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnEncrypt__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnEncrypt__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidDecryptionMaterials__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidDecryptionMaterials__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidDecryptionMaterialsTransition__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidDecryptionMaterialsTransition__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidEncryptionMaterials__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidEncryptionMaterials__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidEncryptionMaterialsTransition__M7_message(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidEncryptionMaterialsTransition__M7_message(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M10_Encryption(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M10_Encryption(AWS.Cryptography.MaterialProviders.EncryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M10_Decryption(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M10_Decryption(AWS.Cryptography.MaterialProviders.DecryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.HierarchicalMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M12_Hierarchical(Dafny.Aws.Cryptography.MaterialProviders.Types._IHierarchicalMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IHierarchicalMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials__M12_Hierarchical(AWS.Cryptography.MaterialProviders.HierarchicalMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput__M9_materials(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput__M9_materials(AWS.Cryptography.MaterialProviders.DecryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput__M17_encryptedDataKeys(Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList(value);
    }
    internal static Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnDecryptInput__M17_encryptedDataKeys(System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnDecryptOutput__M9_materials(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnDecryptOutput__M9_materials(AWS.Cryptography.MaterialProviders.DecryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnEncryptInput__M9_materials(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_OnEncryptInput__M9_materials(AWS.Cryptography.MaterialProviders.EncryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnEncryptOutput__M9_materials(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_OnEncryptOutput__M9_materials(AWS.Cryptography.MaterialProviders.EncryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M10_identifier(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M10_identifier(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static AWS.Cryptography.MaterialProviders.Materials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M9_materials(Dafny.Aws.Cryptography.MaterialProviders.Types._IMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M9_materials(AWS.Cryptography.MaterialProviders.Materials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Materials(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M12_creationTime(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M12_creationTime(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M10_expiryTime(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M10_expiryTime(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int? FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M12_messagesUsed(Wrappers_Compile._IOption<int> value)
    {
      return value.is_None ? (int?)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value.Extract());
    }
    internal static Wrappers_Compile._IOption<int> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M12_messagesUsed(int? value)
    {
      return value == null ? Wrappers_Compile.Option<int>.create_None() : Wrappers_Compile.Option<int>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong((int)value));
    }
    internal static int? FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M9_bytesUsed(Wrappers_Compile._IOption<int> value)
    {
      return value.is_None ? (int?)null : FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value.Extract());
    }
    internal static Wrappers_Compile._IOption<int> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_PutCacheEntryInput__M9_bytesUsed(int? value)
    {
      return value == null ? Wrappers_Compile.Option<int>.create_None() : Wrappers_Compile.Option<int>.create_Some(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong((int)value));
    }
    internal static AWS.Cryptography.MaterialProviders.ECDSA FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm__M5_ECDSA(Dafny.Aws.Cryptography.MaterialProviders.Types._IECDSA value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S5_ECDSA(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IECDSA ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm__M5_ECDSA(AWS.Cryptography.MaterialProviders.ECDSA value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S5_ECDSA(value);
    }
    internal static AWS.Cryptography.MaterialProviders.None FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm__M4_None(Dafny.Aws.Cryptography.MaterialProviders.Types._INone value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_None(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._INone ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_SignatureAlgorithm__M4_None(AWS.Cryptography.MaterialProviders.None value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_None(value);
    }
    internal static AWS.Cryptography.Primitives.DigestAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm__M4_HMAC(Dafny.Aws.Cryptography.Primitives.Types._IDigestAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S15_DigestAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.Primitives.Types._IDigestAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm__M4_HMAC(AWS.Cryptography.Primitives.DigestAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S15_DigestAlgorithm(value);
    }
    internal static AWS.Cryptography.MaterialProviders.None FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm__M4_None(Dafny.Aws.Cryptography.MaterialProviders.Types._INone value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_None(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._INone ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S27_SymmetricSignatureAlgorithm__M4_None(AWS.Cryptography.MaterialProviders.None value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_None(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput__M10_identifier(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput__M10_identifier(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput__M9_bytesUsed(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_UpdaterUsageMetadataInput__M9_bytesUsed(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(value);
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput__M9_algorithm(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput__M9_algorithm(AWS.Cryptography.MaterialProviders.AlgorithmSuiteId value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static AWS.Cryptography.MaterialProviders.CommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput__M16_commitmentPolicy(Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnDecryptInput__M16_commitmentPolicy(AWS.Cryptography.MaterialProviders.CommitmentPolicy value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(value);
    }
    internal static AWS.Cryptography.MaterialProviders.AlgorithmSuiteId FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput__M9_algorithm(Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IAlgorithmSuiteId ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput__M9_algorithm(AWS.Cryptography.MaterialProviders.AlgorithmSuiteId value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_AlgorithmSuiteId(value);
    }
    internal static AWS.Cryptography.MaterialProviders.CommitmentPolicy FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput__M16_commitmentPolicy(Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._ICommitmentPolicy ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_ValidateCommitmentPolicyOnEncryptInput__M16_commitmentPolicy(AWS.Cryptography.MaterialProviders.CommitmentPolicy value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_CommitmentPolicy(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput__M5_start(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput__M5_start(AWS.Cryptography.MaterialProviders.DecryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DecryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput__M4_stop(Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDecryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidDecryptionMaterialsTransitionInput__M4_stop(AWS.Cryptography.MaterialProviders.DecryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DecryptionMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput__M5_start(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput__M5_start(AWS.Cryptography.MaterialProviders.EncryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptionMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput__M4_stop(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptionMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S39_ValidEncryptionMaterialsTransitionInput__M4_stop(AWS.Cryptography.MaterialProviders.EncryptionMaterials value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_EncryptionMaterials(value);
    }
    internal static System.IO.MemoryStream FromDafny_N6_smithy__N3_api__S4_Blob(Dafny.ISequence<byte> value)
    {
      return new System.IO.MemoryStream(value.Elements);
    }
    internal static Dafny.ISequence<byte> ToDafny_N6_smithy__N3_api__S4_Blob(System.IO.MemoryStream value)
    {
      return Dafny.Sequence<byte>.FromArray(value.ToArray());
    }
    internal static int FromDafny_N6_smithy__N3_api__S7_Integer(int value)
    {
      return value;
    }
    internal static int ToDafny_N6_smithy__N3_api__S7_Integer(int value)
    {
      return value;
    }
    internal static string FromDafny_N6_smithy__N3_api__S6_String(Dafny.ISequence<char> value)
    {
      return new string(value.Elements);
    }
    internal static Dafny.ISequence<char> ToDafny_N6_smithy__N3_api__S6_String(string value)
    {
      return Dafny.Sequence<char>.FromString(value);
    }
    public static Amazon.KeyManagementService.IAmazonKeyManagementService FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient value)
    {
      if (value is Com.Amazonaws.Kms.KeyManagementServiceShim shim) { return shim._impl; }
      throw new System.ArgumentException("Custom implementations of Amazon.KeyManagementService.IAmazonKeyManagementService are not supported yet");
    }
    public static Dafny.Com.Amazonaws.Kms.Types.IKeyManagementServiceClient ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_KmsClientReference(Amazon.KeyManagementService.IAmazonKeyManagementService value)
    {
      if (value is Amazon.KeyManagementService.AmazonKeyManagementServiceClient impl) { return new Com.Amazonaws.Kms.KeyManagementServiceShim(impl); }
      throw new System.ArgumentException("Custom implementations of Amazon.KeyManagementService.IAmazonKeyManagementService are not supported yet");
    }
    internal static AWS.Cryptography.MaterialProviders.DiscoveryFilter FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter(Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.DiscoveryFilter concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.DiscoveryFilter)value; AWS.Cryptography.MaterialProviders.DiscoveryFilter converted = new AWS.Cryptography.MaterialProviders.DiscoveryFilter(); converted.AccountIds = (System.Collections.Generic.List<string>)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter__M10_accountIds(concrete._accountIds);
      converted.Partition = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter__M9_partition(concrete._partition); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDiscoveryFilter ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter(AWS.Cryptography.MaterialProviders.DiscoveryFilter value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.DiscoveryFilter(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter__M10_accountIds(value.AccountIds), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter__M9_partition(value.Partition));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(Dafny.ISequence<Dafny.ISequence<char>> value)
    {
      return new System.Collections.Generic.List<string>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList__M6_member));
    }
    internal static Dafny.ISequence<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList(System.Collections.Generic.List<string> value)
    {
      return Dafny.Sequence<Dafny.ISequence<char>>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList__M6_member).ToArray());
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList(Dafny.ISequence<Dafny.ISequence<char>> value)
    {
      return new System.Collections.Generic.List<string>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList__M6_member));
    }
    internal static Dafny.ISequence<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList(System.Collections.Generic.List<string> value)
    {
      return Dafny.Sequence<Dafny.ISequence<char>>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList__M6_member).ToArray());
    }
    public static AWS.Cryptography.MaterialProviders.IClientSupplier FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(
     Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier value)
    {
      //// BEGIN MANUAL EDIT
      /// TODO: [Polymorph][NET] --output-local-service-test miss-handles Resources
      /// https://sim.amazon.com/issues/CrypTool-5109
      return AWS.Cryptography.MaterialProviders.TypeConversion
       .FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(value);
      //// END MANUAL EDIT
    }
    public static Dafny.Aws.Cryptography.MaterialProviders.Types.IClientSupplier ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(
     AWS.Cryptography.MaterialProviders.IClientSupplier value)
    {
      //// BEGIN MANUAL EDIT
      /// TODO: [Polymorph][NET] --output-local-service-test miss-handles Resources
      /// https://sim.amazon.com/issues/CrypTool-5109
      return AWS.Cryptography.MaterialProviders.TypeConversion
       .ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_ClientSupplierReference(value);

      //   
      //   switch (value)
      //  {
      //  case ClientSupplier valueWithImpl:
      //     return valueWithImpl._impl;
      //  case ClientSupplierBase nativeImpl:
      //     return new WrappedNativeWrapper_ClientSupplier(nativeImpl);
      //  default:
      //     throw new System.ArgumentException(
      //         "Custom implementations of ClientSupplier must extend ClientSupplierBase.");
      // }
      //// END MANUAL EDIT
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(Dafny.ISequence<char> value)
    {
      return new string(value.Elements);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(string value)
    {
      return Dafny.Sequence<char>.FromString(value);
    }
    public static Amazon.DynamoDBv2.IAmazonDynamoDB FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference(Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDB__20120810Client value)
    {
      if (value is Com.Amazonaws.Dynamodb.DynamoDBv2Shim shim) { return shim._impl; }
      throw new System.ArgumentException("Custom implementations of Amazon.DynamoDBv2.IAmazonDynamoDBv2 are not supported yet");
    }
    public static Dafny.Com.Amazonaws.Dynamodb.Types.IDynamoDB__20120810Client ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_DdbClientReference(Amazon.DynamoDBv2.IAmazonDynamoDB value)
    {
      if (value is Amazon.DynamoDBv2.AmazonDynamoDBClient impl) { return new Com.Amazonaws.Dynamodb.DynamoDBv2Shim(impl); }
      throw new System.ArgumentException("Custom implementations of Amazon.DynamoDBv2.IAmazonDynamoDBv2 are not supported yet");
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_DdbTableArn(Dafny.ISequence<char> value)
    {
      return new string(value.Elements);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_DdbTableArn(string value)
    {
      return Dafny.Sequence<char>.FromString(value);
    }
    internal static long FromDafny_N6_smithy__N3_api__S4_Long(long value)
    {
      return value;
    }
    internal static long ToDafny_N6_smithy__N3_api__S4_Long(long value)
    {
      return value;
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_PositiveInteger(int value)
    {
      return value;
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_PositiveInteger(int value)
    {
      return value;
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Region(Dafny.ISequence<char> value)
    {
      return new string(value.Elements);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Region(string value)
    {
      return Dafny.Sequence<char>.FromString(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList(Dafny.ISequence<Dafny.ISequence<char>> value)
    {
      return new System.Collections.Generic.List<string>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList__M6_member));
    }
    internal static Dafny.ISequence<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList(System.Collections.Generic.List<string> value)
    {
      return Dafny.Sequence<Dafny.ISequence<char>>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList__M6_member).ToArray());
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(Dafny.ISequence<byte> value)
    {
      return new System.IO.MemoryStream(value.Elements);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(System.IO.MemoryStream value)
    {
      return Dafny.Sequence<byte>.FromArray(value.ToArray());
    }
    internal static Amazon.KeyManagementService.EncryptionAlgorithmSpec FromDafny_N3_com__N9_amazonaws__N3_kms__S23_EncryptionAlgorithmSpec(Dafny.Com.Amazonaws.Kms.Types._IEncryptionAlgorithmSpec value)
    {
      if (value.is_SYMMETRIC__DEFAULT) return Amazon.KeyManagementService.EncryptionAlgorithmSpec.SYMMETRIC_DEFAULT;
      if (value.is_RSAES__OAEP__SHA__1) return Amazon.KeyManagementService.EncryptionAlgorithmSpec.RSAES_OAEP_SHA_1;
      if (value.is_RSAES__OAEP__SHA__256) return Amazon.KeyManagementService.EncryptionAlgorithmSpec.RSAES_OAEP_SHA_256;
      throw new System.ArgumentException("Invalid Amazon.KeyManagementService.EncryptionAlgorithmSpec value");
    }
    internal static Dafny.Com.Amazonaws.Kms.Types._IEncryptionAlgorithmSpec ToDafny_N3_com__N9_amazonaws__N3_kms__S23_EncryptionAlgorithmSpec(Amazon.KeyManagementService.EncryptionAlgorithmSpec value)
    {
      if (Amazon.KeyManagementService.EncryptionAlgorithmSpec.SYMMETRIC_DEFAULT.Equals(value)) return Dafny.Com.Amazonaws.Kms.Types.EncryptionAlgorithmSpec.create_SYMMETRIC__DEFAULT();
      if (Amazon.KeyManagementService.EncryptionAlgorithmSpec.RSAES_OAEP_SHA_1.Equals(value)) return Dafny.Com.Amazonaws.Kms.Types.EncryptionAlgorithmSpec.create_RSAES__OAEP__SHA__1();
      if (Amazon.KeyManagementService.EncryptionAlgorithmSpec.RSAES_OAEP_SHA_256.Equals(value)) return Dafny.Com.Amazonaws.Kms.Types.EncryptionAlgorithmSpec.create_RSAES__OAEP__SHA__256();
      throw new System.ArgumentException("Invalid Amazon.KeyManagementService.EncryptionAlgorithmSpec value");
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(int value)
    {
      return value;
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_PositiveLong(int value)
    {
      return value;
    }
    public static AWS.Cryptography.MaterialProviders.ICryptographicMaterialsCache FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CryptographicMaterialsCacheReference(Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsCache value)
    {
      //// BEGIN MANUAL EDIT
      /// TODO: [Polymorph][NET] --output-local-service-test miss-handles Resources
      /// https://sim.amazon.com/issues/CrypTool-5109
      /*if (value is WrappedNativeWrapper_CryptographicMaterialsCache nativeWrapper) return nativeWrapper._impl;
      return new CryptographicMaterialsCache(value);*/
      return AWS.Cryptography.MaterialProviders.TypeConversion
        .FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CryptographicMaterialsCacheReference(value);
      //// END MANUAL EDIT
    }
    public static Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsCache ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CryptographicMaterialsCacheReference(AWS.Cryptography.MaterialProviders.ICryptographicMaterialsCache value)
    {
      //// BEGIN MANUAL EDIT
      /// TODO: [Polymorph][NET] --output-local-service-test miss-handles Resources
      /// https://sim.amazon.com/issues/CrypTool-5109
      /*switch (value)
      {
        case CryptographicMaterialsCache valueWithImpl:
          return valueWithImpl._impl;
        case CryptographicMaterialsCacheBase nativeImpl:
          return new WrappedNativeWrapper_CryptographicMaterialsCache(nativeImpl);
        default:
          throw new System.ArgumentException(
              "Custom implementations of CryptographicMaterialsCache must extend CryptographicMaterialsCacheBase.");
      }*/
      return AWS.Cryptography.MaterialProviders.TypeConversion
        .ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_CryptographicMaterialsCacheReference(value);
      //// END MANUAL EDIT
    }
    public static AWS.Cryptography.MaterialProviders.ICryptographicMaterialsManager FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CryptographicMaterialsManagerReference(Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsManager value)
    {

      return AWS.Cryptography.MaterialProviders.TypeConversion
       .FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CryptographicMaterialsManagerReference(value);

    }
    public static Dafny.Aws.Cryptography.MaterialProviders.Types.ICryptographicMaterialsManager ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CryptographicMaterialsManagerReference(AWS.Cryptography.MaterialProviders.ICryptographicMaterialsManager value)
    {
      return AWS.Cryptography.MaterialProviders.TypeConversion
       .ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S38_CryptographicMaterialsManagerReference(value);
    }
    public static AWS.Cryptography.MaterialProviders.IKeyring FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring value)
    {
      return AWS.Cryptography.MaterialProviders.TypeConversion
       .FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value);

    }
    public static Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(AWS.Cryptography.MaterialProviders.IKeyring value)
    {
      return AWS.Cryptography.MaterialProviders.TypeConversion
       .ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value);
    }
    internal static System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.IKeyring> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_KeyringList(Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring> value)
    {
      return new System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.IKeyring>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_KeyringList__M6_member));
    }
    internal static Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_KeyringList(System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.IKeyring> value)
    {
      return Dafny.Sequence<Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_KeyringList__M6_member).ToArray());
    }
    internal static System.Collections.Generic.Dictionary<string, string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> value)
    {
      return value.ItemEnumerable.ToDictionary(pair => FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext__M3_key(pair.Car), pair => FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext__M5_value(pair.Cdr));
    }
    internal static Dafny.IMap<Dafny.ISequence<byte>, Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext(System.Collections.Generic.Dictionary<string, string> value)
    {
      return Dafny.Map<Dafny.ISequence<byte>, Dafny.ISequence<byte>>.FromCollection(value.Select(pair =>
         new Dafny.Pair<Dafny.ISequence<byte>, Dafny.ISequence<byte>>(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext__M3_key(pair.Key), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext__M5_value(pair.Value))
     ));
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(Dafny.ISequence<Dafny.ISequence<byte>> value)
    {
      return new System.Collections.Generic.List<string>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys__M6_member));
    }
    internal static Dafny.ISequence<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys(System.Collections.Generic.List<string> value)
    {
      return Dafny.Sequence<Dafny.ISequence<byte>>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys__M6_member).ToArray());
    }
    internal static System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList(Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey> value)
    {
      return new System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList__M6_member));
    }
    internal static Dafny.ISequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList(System.Collections.Generic.List<AWS.Cryptography.MaterialProviders.EncryptedDataKey> value)
    {
      return Dafny.Sequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList__M6_member).ToArray());
    }
    internal static AWS.Cryptography.MaterialProviders.HKDF FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF(Dafny.Aws.Cryptography.MaterialProviders.Types._IHKDF value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.HKDF concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.HKDF)value; AWS.Cryptography.MaterialProviders.HKDF converted = new AWS.Cryptography.MaterialProviders.HKDF(); converted.Hmac = (AWS.Cryptography.Primitives.DigestAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M4_hmac(concrete._hmac);
      converted.SaltLength = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M10_saltLength(concrete._saltLength);
      converted.InputKeyLength = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M14_inputKeyLength(concrete._inputKeyLength);
      converted.OutputKeyLength = (int)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M15_outputKeyLength(concrete._outputKeyLength); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IHKDF ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF(AWS.Cryptography.MaterialProviders.HKDF value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.HKDF(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M4_hmac(value.Hmac), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M10_saltLength(value.SaltLength), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M14_inputKeyLength(value.InputKeyLength), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M15_outputKeyLength(value.OutputKeyLength));
    }
    internal static AWS.Cryptography.MaterialProviders.IDENTITY FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_IDENTITY(Dafny.Aws.Cryptography.MaterialProviders.Types._IIDENTITY value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.IDENTITY concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.IDENTITY)value; AWS.Cryptography.MaterialProviders.IDENTITY converted = new AWS.Cryptography.MaterialProviders.IDENTITY(); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IIDENTITY ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_IDENTITY(AWS.Cryptography.MaterialProviders.IDENTITY value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.IDENTITY();
    }
    internal static AWS.Cryptography.MaterialProviders.None FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_None(Dafny.Aws.Cryptography.MaterialProviders.Types._INone value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.None concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.None)value; AWS.Cryptography.MaterialProviders.None converted = new AWS.Cryptography.MaterialProviders.None(); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._INone ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_None(AWS.Cryptography.MaterialProviders.None value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.None();
    }
    internal static AWS.Cryptography.MaterialProviders.DIRECT_KEY_WRAPPING FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DIRECT_KEY_WRAPPING(Dafny.Aws.Cryptography.MaterialProviders.Types._IDIRECT__KEY__WRAPPING value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.DIRECT__KEY__WRAPPING concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.DIRECT__KEY__WRAPPING)value; AWS.Cryptography.MaterialProviders.DIRECT_KEY_WRAPPING converted = new AWS.Cryptography.MaterialProviders.DIRECT_KEY_WRAPPING(); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDIRECT__KEY__WRAPPING ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DIRECT_KEY_WRAPPING(AWS.Cryptography.MaterialProviders.DIRECT_KEY_WRAPPING value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.DIRECT__KEY__WRAPPING();
    }
    internal static AWS.Cryptography.MaterialProviders.IntermediateKeyWrapping FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping(Dafny.Aws.Cryptography.MaterialProviders.Types._IIntermediateKeyWrapping value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.IntermediateKeyWrapping concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.IntermediateKeyWrapping)value; AWS.Cryptography.MaterialProviders.IntermediateKeyWrapping converted = new AWS.Cryptography.MaterialProviders.IntermediateKeyWrapping(); converted.KeyEncryptionKeyKdf = (AWS.Cryptography.MaterialProviders.DerivationAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M19_keyEncryptionKeyKdf(concrete._keyEncryptionKeyKdf);
      converted.MacKeyKdf = (AWS.Cryptography.MaterialProviders.DerivationAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M9_macKeyKdf(concrete._macKeyKdf);
      converted.PdkEncryptAlgorithm = (AWS.Cryptography.MaterialProviders.Encrypt)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M19_pdkEncryptAlgorithm(concrete._pdkEncryptAlgorithm); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IIntermediateKeyWrapping ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping(AWS.Cryptography.MaterialProviders.IntermediateKeyWrapping value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.IntermediateKeyWrapping(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M19_keyEncryptionKeyKdf(value.KeyEncryptionKeyKdf), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M9_macKeyKdf(value.MacKeyKdf), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M19_pdkEncryptAlgorithm(value.PdkEncryptAlgorithm));
    }
    internal static AWS.Cryptography.Primitives.AES_GCM FromDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM(Dafny.Aws.Cryptography.Primitives.Types._IAES__GCM value)
    {
      Dafny.Aws.Cryptography.Primitives.Types.AES__GCM concrete = (Dafny.Aws.Cryptography.Primitives.Types.AES__GCM)value; AWS.Cryptography.Primitives.AES_GCM converted = new AWS.Cryptography.Primitives.AES_GCM(); converted.KeyLength = (int)FromDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M9_keyLength(concrete._keyLength);
      converted.TagLength = (int)FromDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M9_tagLength(concrete._tagLength);
      converted.IvLength = (int)FromDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M8_ivLength(concrete._ivLength); return converted;
    }
    internal static Dafny.Aws.Cryptography.Primitives.Types._IAES__GCM ToDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM(AWS.Cryptography.Primitives.AES_GCM value)
    {

      return new Dafny.Aws.Cryptography.Primitives.Types.AES__GCM(ToDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M9_keyLength(value.KeyLength), ToDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M9_tagLength(value.TagLength), ToDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M8_ivLength(value.IvLength));
    }
    internal static System.Collections.Generic.List<System.IO.MemoryStream> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_SymmetricSigningKeyList(Dafny.ISequence<Dafny.ISequence<byte>> value)
    {
      return new System.Collections.Generic.List<System.IO.MemoryStream>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_SymmetricSigningKeyList__M6_member));
    }
    internal static Dafny.ISequence<Dafny.ISequence<byte>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_SymmetricSigningKeyList(System.Collections.Generic.List<System.IO.MemoryStream> value)
    {
      return Dafny.Sequence<Dafny.ISequence<byte>>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_SymmetricSigningKeyList__M6_member).ToArray());
    }
    internal static AWS.Cryptography.MaterialProviders.HierarchicalMaterials FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials(Dafny.Aws.Cryptography.MaterialProviders.Types._IHierarchicalMaterials value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.HierarchicalMaterials concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.HierarchicalMaterials)value; AWS.Cryptography.MaterialProviders.HierarchicalMaterials converted = new AWS.Cryptography.MaterialProviders.HierarchicalMaterials(); converted.BranchKeyVersion = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials__M16_branchKeyVersion(concrete._branchKeyVersion);
      converted.BranchKey = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials__M9_branchKey(concrete._branchKey); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IHierarchicalMaterials ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials(AWS.Cryptography.MaterialProviders.HierarchicalMaterials value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.HierarchicalMaterials(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials__M16_branchKeyVersion(value.BranchKeyVersion), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials__M9_branchKey(value.BranchKey));
    }
    internal static AWS.Cryptography.MaterialProviders.ECDSA FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S5_ECDSA(Dafny.Aws.Cryptography.MaterialProviders.Types._IECDSA value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.ECDSA concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.ECDSA)value; AWS.Cryptography.MaterialProviders.ECDSA converted = new AWS.Cryptography.MaterialProviders.ECDSA(); converted.Curve = (AWS.Cryptography.Primitives.ECDSASignatureAlgorithm)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S5_ECDSA__M5_curve(concrete._curve); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IECDSA ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S5_ECDSA(AWS.Cryptography.MaterialProviders.ECDSA value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.ECDSA(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S5_ECDSA__M5_curve(value.Curve));
    }
    internal static AWS.Cryptography.Primitives.DigestAlgorithm FromDafny_N3_aws__N12_cryptography__N10_primitives__S15_DigestAlgorithm(Dafny.Aws.Cryptography.Primitives.Types._IDigestAlgorithm value)
    {
      if (value.is_SHA__512) return AWS.Cryptography.Primitives.DigestAlgorithm.SHA_512;
      if (value.is_SHA__384) return AWS.Cryptography.Primitives.DigestAlgorithm.SHA_384;
      if (value.is_SHA__256) return AWS.Cryptography.Primitives.DigestAlgorithm.SHA_256;
      if (value.is_SHA__1) return AWS.Cryptography.Primitives.DigestAlgorithm.SHA_1;
      throw new System.ArgumentException("Invalid AWS.Cryptography.Primitives.DigestAlgorithm value");
    }
    internal static Dafny.Aws.Cryptography.Primitives.Types._IDigestAlgorithm ToDafny_N3_aws__N12_cryptography__N10_primitives__S15_DigestAlgorithm(AWS.Cryptography.Primitives.DigestAlgorithm value)
    {
      if (AWS.Cryptography.Primitives.DigestAlgorithm.SHA_512.Equals(value)) return Dafny.Aws.Cryptography.Primitives.Types.DigestAlgorithm.create_SHA__512();
      if (AWS.Cryptography.Primitives.DigestAlgorithm.SHA_384.Equals(value)) return Dafny.Aws.Cryptography.Primitives.Types.DigestAlgorithm.create_SHA__384();
      if (AWS.Cryptography.Primitives.DigestAlgorithm.SHA_256.Equals(value)) return Dafny.Aws.Cryptography.Primitives.Types.DigestAlgorithm.create_SHA__256();
      if (AWS.Cryptography.Primitives.DigestAlgorithm.SHA_1.Equals(value)) return Dafny.Aws.Cryptography.Primitives.Types.DigestAlgorithm.create_SHA__1();
      throw new System.ArgumentException("Invalid AWS.Cryptography.Primitives.DigestAlgorithm value");
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter__M10_accountIds(Dafny.ISequence<Dafny.ISequence<char>> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_AccountIdList(value);
    }
    internal static Dafny.ISequence<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter__M10_accountIds(System.Collections.Generic.List<string> value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_AccountIdList(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter__M9_partition(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S15_DiscoveryFilter__M9_partition(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList__M6_member(Dafny.ISequence<char> value)
    {
      return FromDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S14_GrantTokenList__M6_member(string value)
    {
      return ToDafny_N6_smithy__N3_api__S6_String(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList__M6_member(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Region(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S10_RegionList__M6_member(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Region(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList__M6_member(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S12_KmsKeyIdList__M6_member(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S8_KmsKeyId(value);
    }
    internal static AWS.Cryptography.MaterialProviders.IKeyring FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_KeyringList__M6_member(Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types.IKeyring ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S11_KeyringList__M6_member(AWS.Cryptography.MaterialProviders.IKeyring value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_KeyringReference(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext__M3_key(Dafny.ISequence<byte> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext__M3_key(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext__M5_value(Dafny.ISequence<byte> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EncryptionContext__M5_value(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys__M6_member(Dafny.ISequence<byte> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_EncryptionContextKeys__M6_member(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptedDataKey FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList__M6_member(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S20_EncryptedDataKeyList__M6_member(AWS.Cryptography.MaterialProviders.EncryptedDataKey value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey(value);
    }
    internal static AWS.Cryptography.Primitives.DigestAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M4_hmac(Dafny.Aws.Cryptography.Primitives.Types._IDigestAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S15_DigestAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.Primitives.Types._IDigestAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M4_hmac(AWS.Cryptography.Primitives.DigestAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S15_DigestAlgorithm(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M10_saltLength(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S15_PositiveInteger(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M10_saltLength(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S15_PositiveInteger(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M14_inputKeyLength(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S18_SymmetricKeyLength(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M14_inputKeyLength(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S18_SymmetricKeyLength(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M15_outputKeyLength(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S18_SymmetricKeyLength(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S4_HKDF__M15_outputKeyLength(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S18_SymmetricKeyLength(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DerivationAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M19_keyEncryptionKeyKdf(Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M19_keyEncryptionKeyKdf(AWS.Cryptography.MaterialProviders.DerivationAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(value);
    }
    internal static AWS.Cryptography.MaterialProviders.DerivationAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M9_macKeyKdf(Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IDerivationAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M9_macKeyKdf(AWS.Cryptography.MaterialProviders.DerivationAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S19_DerivationAlgorithm(value);
    }
    internal static AWS.Cryptography.MaterialProviders.Encrypt FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M19_pdkEncryptAlgorithm(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncrypt value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt(value);
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncrypt ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_IntermediateKeyWrapping__M19_pdkEncryptAlgorithm(AWS.Cryptography.MaterialProviders.Encrypt value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S7_Encrypt(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M9_keyLength(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S18_SymmetricKeyLength(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M9_keyLength(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S18_SymmetricKeyLength(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M9_tagLength(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S10_Uint8Bytes(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M9_tagLength(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S10_Uint8Bytes(value);
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M8_ivLength(int value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S9_Uint8Bits(value);
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N10_primitives__S7_AES_GCM__M8_ivLength(int value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S9_Uint8Bits(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_SymmetricSigningKeyList__M6_member(Dafny.ISequence<byte> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S23_SymmetricSigningKeyList__M6_member(System.IO.MemoryStream value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials__M16_branchKeyVersion(Dafny.ISequence<byte> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials__M16_branchKeyVersion(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials__M9_branchKey(Dafny.ISequence<byte> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S21_HierarchicalMaterials__M9_branchKey(System.IO.MemoryStream value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S6_Secret(value);
    }
    internal static AWS.Cryptography.Primitives.ECDSASignatureAlgorithm FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S5_ECDSA__M5_curve(Dafny.Aws.Cryptography.Primitives.Types._IECDSASignatureAlgorithm value)
    {
      return FromDafny_N3_aws__N12_cryptography__N10_primitives__S23_ECDSASignatureAlgorithm(value);
    }
    internal static Dafny.Aws.Cryptography.Primitives.Types._IECDSASignatureAlgorithm ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S5_ECDSA__M5_curve(AWS.Cryptography.Primitives.ECDSASignatureAlgorithm value)
    {
      return ToDafny_N3_aws__N12_cryptography__N10_primitives__S23_ECDSASignatureAlgorithm(value);
    }
    internal static System.Collections.Generic.List<string> FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_AccountIdList(Dafny.ISequence<Dafny.ISequence<char>> value)
    {
      return new System.Collections.Generic.List<string>(value.Elements.Select(FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_AccountIdList__M6_member));
    }
    internal static Dafny.ISequence<Dafny.ISequence<char>> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_AccountIdList(System.Collections.Generic.List<string> value)
    {
      return Dafny.Sequence<Dafny.ISequence<char>>.FromArray(value.Select(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_AccountIdList__M6_member).ToArray());
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(Dafny.ISequence<byte> value)
    {
      System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding(false, true);
      return utf8.GetString(value.Elements);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(string value)
    {
      System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding(false, true);
      return Dafny.Sequence<byte>.FromArray(utf8.GetBytes(value));
    }
    internal static AWS.Cryptography.MaterialProviders.EncryptedDataKey FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey(Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey value)
    {
      Dafny.Aws.Cryptography.MaterialProviders.Types.EncryptedDataKey concrete = (Dafny.Aws.Cryptography.MaterialProviders.Types.EncryptedDataKey)value; AWS.Cryptography.MaterialProviders.EncryptedDataKey converted = new AWS.Cryptography.MaterialProviders.EncryptedDataKey(); converted.KeyProviderId = (string)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M13_keyProviderId(concrete._keyProviderId);
      converted.KeyProviderInfo = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M15_keyProviderInfo(concrete._keyProviderInfo);
      converted.Ciphertext = (System.IO.MemoryStream)FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M10_ciphertext(concrete._ciphertext); return converted;
    }
    internal static Dafny.Aws.Cryptography.MaterialProviders.Types._IEncryptedDataKey ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey(AWS.Cryptography.MaterialProviders.EncryptedDataKey value)
    {

      return new Dafny.Aws.Cryptography.MaterialProviders.Types.EncryptedDataKey(ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M13_keyProviderId(value.KeyProviderId), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M15_keyProviderInfo(value.KeyProviderInfo), ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M10_ciphertext(value.Ciphertext));
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N10_primitives__S15_PositiveInteger(int value)
    {
      return value;
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N10_primitives__S15_PositiveInteger(int value)
    {
      return value;
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N10_primitives__S18_SymmetricKeyLength(int value)
    {
      return value;
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N10_primitives__S18_SymmetricKeyLength(int value)
    {
      return value;
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N10_primitives__S10_Uint8Bytes(int value)
    {
      return value;
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N10_primitives__S10_Uint8Bytes(int value)
    {
      return value;
    }
    internal static int FromDafny_N3_aws__N12_cryptography__N10_primitives__S9_Uint8Bits(int value)
    {
      return value;
    }
    internal static int ToDafny_N3_aws__N12_cryptography__N10_primitives__S9_Uint8Bits(int value)
    {
      return value;
    }
    internal static AWS.Cryptography.Primitives.ECDSASignatureAlgorithm FromDafny_N3_aws__N12_cryptography__N10_primitives__S23_ECDSASignatureAlgorithm(Dafny.Aws.Cryptography.Primitives.Types._IECDSASignatureAlgorithm value)
    {
      if (value.is_ECDSA__P384) return AWS.Cryptography.Primitives.ECDSASignatureAlgorithm.ECDSA_P384;
      if (value.is_ECDSA__P256) return AWS.Cryptography.Primitives.ECDSASignatureAlgorithm.ECDSA_P256;
      throw new System.ArgumentException("Invalid AWS.Cryptography.Primitives.ECDSASignatureAlgorithm value");
    }
    internal static Dafny.Aws.Cryptography.Primitives.Types._IECDSASignatureAlgorithm ToDafny_N3_aws__N12_cryptography__N10_primitives__S23_ECDSASignatureAlgorithm(AWS.Cryptography.Primitives.ECDSASignatureAlgorithm value)
    {
      if (AWS.Cryptography.Primitives.ECDSASignatureAlgorithm.ECDSA_P384.Equals(value)) return Dafny.Aws.Cryptography.Primitives.Types.ECDSASignatureAlgorithm.create_ECDSA__P384();
      if (AWS.Cryptography.Primitives.ECDSASignatureAlgorithm.ECDSA_P256.Equals(value)) return Dafny.Aws.Cryptography.Primitives.Types.ECDSASignatureAlgorithm.create_ECDSA__P256();
      throw new System.ArgumentException("Invalid AWS.Cryptography.Primitives.ECDSASignatureAlgorithm value");
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_AccountIdList__M6_member(Dafny.ISequence<char> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_AccountId(value);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S13_AccountIdList__M6_member(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_AccountId(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M13_keyProviderId(Dafny.ISequence<byte> value)
    {
      return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M13_keyProviderId(string value)
    {
      return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_Utf8Bytes(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M15_keyProviderInfo(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M15_keyProviderInfo(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static System.IO.MemoryStream FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M10_ciphertext(Dafny.ISequence<byte> value)
    {
      return FromDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static Dafny.ISequence<byte> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S16_EncryptedDataKey__M10_ciphertext(System.IO.MemoryStream value)
    {
      return ToDafny_N6_smithy__N3_api__S4_Blob(value);
    }
    internal static string FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_AccountId(Dafny.ISequence<char> value)
    {
      return new string(value.Elements);
    }
    internal static Dafny.ISequence<char> ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S9_AccountId(string value)
    {
      return Dafny.Sequence<char>.FromString(value);
    }
    public static System.Exception FromDafny_CommonError(Dafny.Aws.Cryptography.MaterialProviders.Types._IError value)
    {
      switch (value)
      {

        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_AwsCryptographicMaterialProvidersException dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S42_AwsCryptographicMaterialProvidersException(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_EntryAlreadyExists dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_EntryAlreadyExists(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_EntryDoesNotExist dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EntryDoesNotExist(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfo dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_InvalidAlgorithmSuiteInfo(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfoOnDecrypt dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnDecrypt(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidAlgorithmSuiteInfoOnEncrypt dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnEncrypt(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidDecryptionMaterials dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidDecryptionMaterials(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidDecryptionMaterialsTransition dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidDecryptionMaterialsTransition(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidEncryptionMaterials dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidEncryptionMaterials(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_InvalidEncryptionMaterialsTransition dafnyVal:
          return FromDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidEncryptionMaterialsTransition(dafnyVal);
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_CollectionOfErrors dafnyVal:
          return new CollectionOfErrors(new System.Collections.Generic.List<Exception>(dafnyVal._list.Elements.Select(x => TypeConversion.FromDafny_CommonError(x))));
        case Dafny.Aws.Cryptography.MaterialProviders.Types.Error_Opaque dafnyVal:
          return new OpaqueError(dafnyVal._obj);
        default:
          // The switch MUST be complete for _IError, so `value` MUST NOT be an _IError. (How did you get here?)
          return new OpaqueError();
      }
    }
    public static Dafny.Aws.Cryptography.MaterialProviders.Types._IError ToDafny_CommonError(System.Exception value)
    {

      switch (value)
      {
        case AWS.Cryptography.MaterialProviders.AwsCryptographicMaterialProvidersException exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S42_AwsCryptographicMaterialProvidersException(exception);
        case AWS.Cryptography.MaterialProviders.EntryAlreadyExists exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S18_EntryAlreadyExists(exception);
        case AWS.Cryptography.MaterialProviders.EntryDoesNotExist exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S17_EntryDoesNotExist(exception);
        case AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfo exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S25_InvalidAlgorithmSuiteInfo(exception);
        case AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfoOnDecrypt exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnDecrypt(exception);
        case AWS.Cryptography.MaterialProviders.InvalidAlgorithmSuiteInfoOnEncrypt exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S34_InvalidAlgorithmSuiteInfoOnEncrypt(exception);
        case AWS.Cryptography.MaterialProviders.InvalidDecryptionMaterials exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidDecryptionMaterials(exception);
        case AWS.Cryptography.MaterialProviders.InvalidDecryptionMaterialsTransition exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidDecryptionMaterialsTransition(exception);
        case AWS.Cryptography.MaterialProviders.InvalidEncryptionMaterials exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S26_InvalidEncryptionMaterials(exception);
        case AWS.Cryptography.MaterialProviders.InvalidEncryptionMaterialsTransition exception:
          return ToDafny_N3_aws__N12_cryptography__N17_materialProviders__S36_InvalidEncryptionMaterialsTransition(exception);
        case CollectionOfErrors collectionOfErrors:
          return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_CollectionOfErrors(
              Dafny.Sequence<Dafny.Aws.Cryptography.MaterialProviders.Types._IError>
              .FromArray(
                  collectionOfErrors.list.Select
                      (x => TypeConversion.ToDafny_CommonError(x))
                  .ToArray()
              )
          );

        // OpaqueError is redundant, but listed for completeness.
        case OpaqueError exception:
          return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_Opaque(exception);
        case System.Exception exception:
          return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_Opaque(exception);
        default:
          // The switch MUST be complete for System.Exception, so `value` MUST NOT be an System.Exception. (How did you get here?)
          return new Dafny.Aws.Cryptography.MaterialProviders.Types.Error_Opaque(value);
      }
    }
  }
}
