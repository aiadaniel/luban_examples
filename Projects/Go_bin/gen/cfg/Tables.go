
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "luban_examples/go_bin/bright/serialization"

type ByteBufLoader func(string) (*serialization.ByteBuf, error)

type Tables struct {
    TbBlackboard *AiTbBlackboard
    TbBehaviorTree *AiTbBehaviorTree
    TbClazz *BlueprintTbClazz
    TbDrop *BonusTbDrop
    TbGlobalConfig *CommonTbGlobalConfig
    TbErrorInfo *ErrorTbErrorInfo
    TbCodeInfo *ErrorTbCodeInfo
    TbItem *ItemTbItem
    TbItemFunc *ItemTbItemFunc
    TbItemExtra *ItemTbItemExtra
    TbL10NDemo *L10nTbL10NDemo
    TbPatchDemo *L10nTbPatchDemo
    TbSystemMail *MailTbSystemMail
    TbGlobalMail *MailTbGlobalMail
    TbRoleLevelExpAttr *RoleTbRoleLevelExpAttr
    TbRoleLevelBonusCoefficient *RoleTbRoleLevelBonusCoefficient
    TbTestTag *TagTbTestTag
    TbFullTypes *TestTbFullTypes
    TbSingleton *TestTbSingleton
    TbNotIndexList *TestTbNotIndexList
    TbMultiUnionIndexList *TestTbMultiUnionIndexList
    TbMultiIndexList *TestTbMultiIndexList
    TbDataFromMisc *TestTbDataFromMisc
    TbMultiRowRecord *TestTbMultiRowRecord
    TbTestMultiColumn *TestTbTestMultiColumn
    TbMultiRowTitle *TestTbMultiRowTitle
    TbTestNull *TestTbTestNull
    TbDemoPrimitive *TestTbDemoPrimitive
    TbTestString *TestTbTestString
    TbDemoGroup *TestTbDemoGroup
    TbDemoGroup_C *TestTbDemoGroup_C
    TbDemoGroup_S *TestTbDemoGroup_S
    TbDemoGroup_E *TestTbDemoGroup_E
    TbTestGlobal *TestTbTestGlobal
    TbTestBeRef *TestTbTestBeRef
    TbTestBeRef2 *TestTbTestBeRef2
    TbTestRef *TestTbTestRef
    TbTestSize *TestTbTestSize
    TbTestSet *TestTbTestSet
    TbDetectCsvEncoding *TestTbDetectCsvEncoding
    TbDefineFromExcel *TestTbDefineFromExcel
    TbDefineFromExcelOne *TestTbDefineFromExcelOne
    TbTestIndex *TestTbTestIndex
    TbTestMap *TestTbTestMap
    TbExcelFromJson *TestTbExcelFromJson
    TbCompositeJsonTable1 *TestTbCompositeJsonTable1
    TbCompositeJsonTable2 *TestTbCompositeJsonTable2
    TbCompositeJsonTable3 *TestTbCompositeJsonTable3
    TbExcelFromJsonMultiRow *TestTbExcelFromJsonMultiRow
    TbTestSep *TestTbTestSep
    TbTestExternalType *TestTbTestExternalType
    TbDemoGroupDefineFromExcel *TestTbDemoGroupDefineFromExcel
    TbDefineFromExcel2 *TestTbDefineFromExcel2
    TbTestExcelBean *TestTbTestExcelBean
    TbTestDesc *TestTbTestDesc
}

func NewTables(loader ByteBufLoader) (*Tables, error) {
    var err error
    var buf *serialization.ByteBuf

    tables := &Tables{}
    if buf, err = loader("ai_tbblackboard") ; err != nil {
        return nil, err
    }
    if tables.TbBlackboard, err = NewAiTbBlackboard(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("ai_tbbehaviortree") ; err != nil {
        return nil, err
    }
    if tables.TbBehaviorTree, err = NewAiTbBehaviorTree(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("blueprint_tbclazz") ; err != nil {
        return nil, err
    }
    if tables.TbClazz, err = NewBlueprintTbClazz(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("bonus_tbdrop") ; err != nil {
        return nil, err
    }
    if tables.TbDrop, err = NewBonusTbDrop(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("common_tbglobalconfig") ; err != nil {
        return nil, err
    }
    if tables.TbGlobalConfig, err = NewCommonTbGlobalConfig(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("error_tberrorinfo") ; err != nil {
        return nil, err
    }
    if tables.TbErrorInfo, err = NewErrorTbErrorInfo(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("error_tbcodeinfo") ; err != nil {
        return nil, err
    }
    if tables.TbCodeInfo, err = NewErrorTbCodeInfo(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("item_tbitem") ; err != nil {
        return nil, err
    }
    if tables.TbItem, err = NewItemTbItem(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("item_tbitemfunc") ; err != nil {
        return nil, err
    }
    if tables.TbItemFunc, err = NewItemTbItemFunc(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("item_tbitemextra") ; err != nil {
        return nil, err
    }
    if tables.TbItemExtra, err = NewItemTbItemExtra(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("l10n_tbl10ndemo") ; err != nil {
        return nil, err
    }
    if tables.TbL10NDemo, err = NewL10nTbL10NDemo(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("l10n_tbpatchdemo") ; err != nil {
        return nil, err
    }
    if tables.TbPatchDemo, err = NewL10nTbPatchDemo(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("mail_tbsystemmail") ; err != nil {
        return nil, err
    }
    if tables.TbSystemMail, err = NewMailTbSystemMail(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("mail_tbglobalmail") ; err != nil {
        return nil, err
    }
    if tables.TbGlobalMail, err = NewMailTbGlobalMail(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("role_tbrolelevelexpattr") ; err != nil {
        return nil, err
    }
    if tables.TbRoleLevelExpAttr, err = NewRoleTbRoleLevelExpAttr(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("role_tbrolelevelbonuscoefficient") ; err != nil {
        return nil, err
    }
    if tables.TbRoleLevelBonusCoefficient, err = NewRoleTbRoleLevelBonusCoefficient(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("tag_tbtesttag") ; err != nil {
        return nil, err
    }
    if tables.TbTestTag, err = NewTagTbTestTag(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbfulltypes") ; err != nil {
        return nil, err
    }
    if tables.TbFullTypes, err = NewTestTbFullTypes(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbsingleton") ; err != nil {
        return nil, err
    }
    if tables.TbSingleton, err = NewTestTbSingleton(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbnotindexlist") ; err != nil {
        return nil, err
    }
    if tables.TbNotIndexList, err = NewTestTbNotIndexList(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbmultiunionindexlist") ; err != nil {
        return nil, err
    }
    if tables.TbMultiUnionIndexList, err = NewTestTbMultiUnionIndexList(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbmultiindexlist") ; err != nil {
        return nil, err
    }
    if tables.TbMultiIndexList, err = NewTestTbMultiIndexList(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdatafrommisc") ; err != nil {
        return nil, err
    }
    if tables.TbDataFromMisc, err = NewTestTbDataFromMisc(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbmultirowrecord") ; err != nil {
        return nil, err
    }
    if tables.TbMultiRowRecord, err = NewTestTbMultiRowRecord(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestmulticolumn") ; err != nil {
        return nil, err
    }
    if tables.TbTestMultiColumn, err = NewTestTbTestMultiColumn(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbmultirowtitle") ; err != nil {
        return nil, err
    }
    if tables.TbMultiRowTitle, err = NewTestTbMultiRowTitle(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestnull") ; err != nil {
        return nil, err
    }
    if tables.TbTestNull, err = NewTestTbTestNull(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdemoprimitive") ; err != nil {
        return nil, err
    }
    if tables.TbDemoPrimitive, err = NewTestTbDemoPrimitive(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbteststring") ; err != nil {
        return nil, err
    }
    if tables.TbTestString, err = NewTestTbTestString(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdemogroup") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroup, err = NewTestTbDemoGroup(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdemogroup_c") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroup_C, err = NewTestTbDemoGroup_C(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdemogroup_s") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroup_S, err = NewTestTbDemoGroup_S(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdemogroup_e") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroup_E, err = NewTestTbDemoGroup_E(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestglobal") ; err != nil {
        return nil, err
    }
    if tables.TbTestGlobal, err = NewTestTbTestGlobal(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestberef") ; err != nil {
        return nil, err
    }
    if tables.TbTestBeRef, err = NewTestTbTestBeRef(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestberef2") ; err != nil {
        return nil, err
    }
    if tables.TbTestBeRef2, err = NewTestTbTestBeRef2(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestref") ; err != nil {
        return nil, err
    }
    if tables.TbTestRef, err = NewTestTbTestRef(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestsize") ; err != nil {
        return nil, err
    }
    if tables.TbTestSize, err = NewTestTbTestSize(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestset") ; err != nil {
        return nil, err
    }
    if tables.TbTestSet, err = NewTestTbTestSet(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdetectcsvencoding") ; err != nil {
        return nil, err
    }
    if tables.TbDetectCsvEncoding, err = NewTestTbDetectCsvEncoding(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdefinefromexcel") ; err != nil {
        return nil, err
    }
    if tables.TbDefineFromExcel, err = NewTestTbDefineFromExcel(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdefinefromexcelone") ; err != nil {
        return nil, err
    }
    if tables.TbDefineFromExcelOne, err = NewTestTbDefineFromExcelOne(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestindex") ; err != nil {
        return nil, err
    }
    if tables.TbTestIndex, err = NewTestTbTestIndex(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestmap") ; err != nil {
        return nil, err
    }
    if tables.TbTestMap, err = NewTestTbTestMap(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbexcelfromjson") ; err != nil {
        return nil, err
    }
    if tables.TbExcelFromJson, err = NewTestTbExcelFromJson(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbcompositejsontable1") ; err != nil {
        return nil, err
    }
    if tables.TbCompositeJsonTable1, err = NewTestTbCompositeJsonTable1(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbcompositejsontable2") ; err != nil {
        return nil, err
    }
    if tables.TbCompositeJsonTable2, err = NewTestTbCompositeJsonTable2(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbcompositejsontable3") ; err != nil {
        return nil, err
    }
    if tables.TbCompositeJsonTable3, err = NewTestTbCompositeJsonTable3(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbexcelfromjsonmultirow") ; err != nil {
        return nil, err
    }
    if tables.TbExcelFromJsonMultiRow, err = NewTestTbExcelFromJsonMultiRow(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestsep") ; err != nil {
        return nil, err
    }
    if tables.TbTestSep, err = NewTestTbTestSep(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestexternaltype") ; err != nil {
        return nil, err
    }
    if tables.TbTestExternalType, err = NewTestTbTestExternalType(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdemogroupdefinefromexcel") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroupDefineFromExcel, err = NewTestTbDemoGroupDefineFromExcel(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbdefinefromexcel2") ; err != nil {
        return nil, err
    }
    if tables.TbDefineFromExcel2, err = NewTestTbDefineFromExcel2(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestexcelbean") ; err != nil {
        return nil, err
    }
    if tables.TbTestExcelBean, err = NewTestTbTestExcelBean(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test_tbtestdesc") ; err != nil {
        return nil, err
    }
    if tables.TbTestDesc, err = NewTestTbTestDesc(buf) ; err != nil {
        return nil, err
    }
    return tables, nil
}
