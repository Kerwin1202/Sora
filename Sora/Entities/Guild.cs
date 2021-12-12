﻿using System;
using Sora.Entities.Base;

namespace Sora.Entities;

//TODO 完善相关方法
/// <summary>
/// 频道实例
/// </summary>
public class Guild : BaseModel
{
    #region 属性

    /// <summary>
    /// 频道ID
    /// </summary>
    public long Id { get; }

    #endregion

    #region 构造函数

    /// <summary>
    /// 初始化
    /// </summary>
    /// <param name="serviceId">服务ID</param>
    /// <param name="connectionId">服务器连接标识</param>
    /// <param name="gid">频道ID</param>
    internal Guild(Guid serviceId, Guid connectionId, long gid) : base(serviceId, connectionId)
    {
        Id = gid;
    }

    #endregion

    #region 转换方法

    /// <summary>
    /// 定义将 <see cref="User"/> 对象转换为 <see cref="long"/>
    /// </summary>
    /// <param name="value">转换的 <see cref="User"/> 对象</param>
    public static implicit operator long(Guild value)
    {
        return value.Id;
    }

    /// <summary>
    /// 定义将 <see cref="User"/> 对象转换为 <see cref="string"/>
    /// </summary>
    /// <param name="value">转换的 <see cref="User"/> 对象</param>
    public static implicit operator string(Guild value)
    {
        return value.ToString();
    }

    #endregion
}